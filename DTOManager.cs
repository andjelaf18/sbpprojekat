using IznajmljivanjeVozila.Entiteti;
using IznajmljivanjeVozila.Mapiranja;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IznajmljivanjeVozila
{
    
    public class DTOManager
    {

        #region Korisnik

        public static List<KorisnikView> VratiSveKorisnike() //citanje
        {
            List<KorisnikView> korisnici = new List<KorisnikView>();

            ISession s = DataLayer.GetSession();

            foreach (Korisnik k in s.Query<Korisnik>())
            {
                korisnici.Add(new KorisnikView(k));
            }

            s.Close();

            return korisnici;
        }

        public static bool DodajKorisnika(KorisnikView k) //dodavanje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik novi = new Korisnik
                {
                    Id = k.Id,
                    Adresa = k.Adresa,
                    BrojTelefona = k.BrojTelefona,
                    DatumRegistracije = k.DatumRegistracije,
                    Email = k.Email,
                    NacinVerifikacije = k.NacinVerifikacije,
                    StatusNaloga = "Aktivan"
                };

                ITransaction t = s.BeginTransaction();
                s.Save(novi);
                t.Commit();

                s.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static KorisnikView VratiKorisnika(int id) //koga smo izabrali za izmenu
        {
            ISession s = DataLayer.GetSession();

            Korisnik k = s.Load<Korisnik>(id);
            KorisnikView korisnik = new KorisnikView(k);

            s.Close();

            return korisnik;
        }

        public static bool IzmeniKorisnika(KorisnikView k) //izmena
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik korisnik = s.Load<Korisnik>(k.Id);

                korisnik.Adresa = k.Adresa;
                korisnik.BrojTelefona = k.BrojTelefona;
                korisnik.Email = k.Email;
                korisnik.DatumRegistracije = k.DatumRegistracije;
                korisnik.StatusNaloga = k.StatusNaloga;
                korisnik.NacinVerifikacije = k.NacinVerifikacije;

                ITransaction t = s.BeginTransaction();
                s.Update(korisnik);
                t.Commit();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private static int IzvrsiSQLZaKorisnika( //pomocna metoda za trajno brisanje korisnika, 
            //jer prethodna metoda ga nije dobro brisala jer je on povezan u vise tabele i to je pravilo problem
         ISession s,
         string sql,
         int idKorisnika)
        {
            return s.CreateSQLQuery(sql)
                .SetParameter("id", idKorisnika)
                .ExecuteUpdate();
        
        }

        public static bool ObrisiKorisnikaSvuda(
    int idKorisnika)
        {
            using ISession s = DataLayer.GetSession();
            using ITransaction t = s.BeginTransaction();

            try
            {
                // Vožnje više ne smeju da pokazuju na rezervacije korisnika.
                IzvrsiSQLZaKorisnika(
                    s,
                    @"UPDATE VOZNJA
              SET ID_REZERVACIJE = NULL
              WHERE ID_REZERVACIJE IN
              (
                  SELECT ID_REZERVACIJE
                  FROM REZERVACIJA
                  WHERE ID_K = :id
              )",
                    idKorisnika
                );

                // Brišemo rezervacije koje je napravio korisnik.
                IzvrsiSQLZaKorisnika(
                    s,
                    @"DELETE FROM REZERVACIJA
              WHERE ID_K = :id",
                    idKorisnika
                );

                // Ako je korisnik fizičko lice i bio je vozač
                // u nekoj tuđoj rezervaciji, uklanjamo vezu ka njemu.
                IzvrsiSQLZaKorisnika(
                    s,
                    @"UPDATE REZERVACIJA
              SET ID_VOZACA = NULL
              WHERE ID_VOZACA IN
              (
                  SELECT ID_FL
                  FROM FIZICKA_LICA
                  WHERE ID_KORISNIKA = :id
              )",
                    idKorisnika
                );

                // Odvajamo vožnje od službenih vožnji tog lica.
                IzvrsiSQLZaKorisnika(
                    s,
                    @"UPDATE VOZNJA
              SET SLUZBENA_VOZNJA = NULL
              WHERE SLUZBENA_VOZNJA IN
              (
                  SELECT ID_S_VOZNJE
                  FROM SLUZBENA_VOZNJA
                  WHERE OVLASCENO_LICE IN
                  (
                      SELECT ID_FL
                      FROM FIZICKA_LICA
                      WHERE ID_KORISNIKA = :id
                  )
              )",
                    idKorisnika
                );

                IzvrsiSQLZaKorisnika(
                    s,
                    @"DELETE FROM SLUZBENA_VOZNJA
              WHERE OVLASCENO_LICE IN
              (
                  SELECT ID_FL
                  FROM FIZICKA_LICA
                  WHERE ID_KORISNIKA = :id
              )",
                    idKorisnika
                );

                IzvrsiSQLZaKorisnika(
                    s,
                    @"DELETE FROM KORISNIK_ULOGA
              WHERE ID_KORISNIKA = :id",
                    idKorisnika
                );

                IzvrsiSQLZaKorisnika(
                    s,
                    @"DELETE FROM NACIN_PLACANJA
              WHERE ID_KORISNIKA = :id",
                    idKorisnika
                );

                IzvrsiSQLZaKorisnika(
                    s,
                    @"DELETE FROM VERIFIKACIJA
              WHERE ID_KORISNIKA = :id",
                    idKorisnika
                );

                IzvrsiSQLZaKorisnika(
                    s,
                    @"DELETE FROM PRAVNA_LICA
              WHERE ID_KORISNIKA = :id",
                    idKorisnika
                );

                IzvrsiSQLZaKorisnika(
                    s,
                    @"DELETE FROM FIZICKA_LICA
              WHERE ID_KORISNIKA = :id",
                    idKorisnika
                );

                int brojObrisanihKorisnika =
                    IzvrsiSQLZaKorisnika(
                        s,
                        @"DELETE FROM KORISNIK
                  WHERE ID_KORISNIKA = :id",
                        idKorisnika
                    );

                t.Commit();

                return brojObrisanihKorisnika > 0;
            }
            catch (Exception ex)
            {
                if (t.IsActive)
                {
                    t.Rollback();
                }

                MessageBox.Show(
                    ex.InnerException?.Message ?? ex.Message,
                    "Greška pri brisanju korisnika"
                );

                return false;
            }
        }

        public static List<PLicaView> VratiSvaPravnaLica() //citanje svih pravnih lica
        {
            List<PLicaView> plica = new List<PLicaView>();

            ISession s = DataLayer.GetSession();

            foreach (PravnaLica pl in s.Query<PravnaLica>())
            {
                plica.Add(new PLicaView(pl));
            }

            s.Close();

            return plica;
        }

        public static List<NacinPlacanjaView> VratiPlacanjaKorisnika(int idKorisnika)
        {
            List<NacinPlacanjaView> placanja = new List<NacinPlacanjaView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<NacinPlacanja> svaPlacanja =
                from np in s.Query<NacinPlacanja>()
                where np.Korisnik.Id == idKorisnika
                select np;

            foreach (NacinPlacanja np in svaPlacanja)
                placanja.Add(new NacinPlacanjaView(np));

            s.Close();

            return placanja;
        }

        public static bool DodajNoviNacinPlacanja(NacinPlacanjaView npv) //dodavanje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NacinPlacanja novi = new NacinPlacanja
                {
                    IdPlacanja = npv.Id,
                    TipPlacanja = npv.TipPlacanja,
                    Status = npv.Status,
                    DatumDodavanjaOgranicenja = npv.DatumOgranicenja,
                    Korisnik = s.Load<Korisnik>(npv.IdKorisnika)
                };

                ITransaction t = s.BeginTransaction();
                s.Save(novi);
                t.Commit();

                s.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static NacinPlacanjaView VratiNacinPlacanja(int id) //koga smo izabrali za izmenu
        {
            ISession s = DataLayer.GetSession();

            NacinPlacanja np = s.Load<NacinPlacanja>(id);
            NacinPlacanjaView nacinplacanja = new NacinPlacanjaView(np);

            s.Close();

            return nacinplacanja;
        }

        public static bool IzmenaNacinaPlacanja(NacinPlacanjaView npv) //izmena
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NacinPlacanja nacinPlacanja = s.Load<NacinPlacanja>(npv.Id);

                nacinPlacanja.TipPlacanja = npv.TipPlacanja;
                nacinPlacanja.Status = npv.Status;
                nacinPlacanja.DatumDodavanjaOgranicenja = npv.DatumOgranicenja;

                ITransaction t = s.BeginTransaction();
                s.Update(nacinPlacanja);
                t.Commit();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static List<KorisnikCombo> VratiKorisnikeZaCombo() 
        {
            List<KorisnikCombo> korisnici = new List<KorisnikCombo>();

            ISession s = DataLayer.GetSession();

            foreach (Korisnik k in s.Query<Korisnik>())
            {
                korisnici.Add(new KorisnikCombo(k));
            }

            s.Close();

            return korisnici;
        }

        #endregion

        #region Vozilo
        public static List<VoziloView> VratiSvaVozila() //citanje
        {
            List<VoziloView> vozila = new List<VoziloView>();

            ISession s = DataLayer.GetSession();

            foreach (Vozilo v in s.Query<Vozilo>())
            {
                vozila.Add(new VoziloView(v));
            }

            s.Close();

            return vozila;
        }

        public static bool DodajVozilo(VoziloView v) //dodavanje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo novoVozilo = new Vozilo
                {
                    IdVozila = v.Id,
                    Registracija = v.Registracija,
                    VinBroj = v.VinBr,
                    Marka = v.Marka,
                    ModelVozila = v.Model,
                    GodProizvodnje = v.GodProizvodnje,
                    DatumNabavke = v.DatumNabavke,
                    Status = v.Status,
                    TipKoriscenja = v.TipKoriscenja,
                    BrSedista = v.BrSedista,
                    StanjeEnterijera = v.StanjeEnterijera,
                    StanjeEksterijera = v.StanjeEksterijera,
                    DodatnaOprema = v.DodatnaOprema
                };

                ITransaction t = s.BeginTransaction();
                s.Save(novoVozilo);
                t.Commit();

                s.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static VoziloView VratiVozilo(int id) //koga smo izabrali za izmenu
        {
            ISession s = DataLayer.GetSession();

            Vozilo v = s.Load<Vozilo>(id);
            VoziloView korisnik = new VoziloView(v);

            s.Close();

            return korisnik;
        }

        public static bool IzmeniVozilo(VoziloView v) //izmena
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Load<Vozilo>(v.Id);

                vozilo.IdVozila = v.Id;
                vozilo.Registracija = v.Registracija;
                vozilo.VinBroj = v.VinBr;
                vozilo.Marka = v.Marka;
                vozilo.ModelVozila = v.Model;
                vozilo.GodProizvodnje = v.GodProizvodnje;
                vozilo.DatumNabavke = v.DatumNabavke;
                vozilo.Status = v.Status;
                vozilo.TipKoriscenja = v.TipKoriscenja;
                vozilo.BrSedista = v.BrSedista;
                vozilo.StanjeEnterijera = v.StanjeEnterijera;
                vozilo.StanjeEksterijera = v.StanjeEksterijera;
                vozilo.DodatnaOprema = v.DodatnaOprema;

                ITransaction t = s.BeginTransaction();
                s.Update(vozilo);
                t.Commit();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void obrisiVozilo(int id) //brisanje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IznajmljivanjeVozila.Entiteti.Vozilo v = s.Load<IznajmljivanjeVozila.Entiteti.Vozilo>(id);

                s.Delete(v);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //PRETRAGA VOZILA
        public static List<PretrazenoVozilo> PretraziVozila(
            string marka,
            string model,
            string status,
            string tipKoriscenja,
            string namena,
            string tipPogona
           )
        {
            List<PretrazenoVozilo> vozila = new List<PretrazenoVozilo>();

            ISession s = DataLayer.GetSession();

            List<Vozilo> rezultat = s.Query<Vozilo>().ToList();

            if (!string.IsNullOrWhiteSpace(marka))
                rezultat = rezultat.Where(v => v.Marka.Contains(marka)).ToList();

            if (!string.IsNullOrWhiteSpace(model))
                rezultat = rezultat.Where(v => v.ModelVozila.Contains(model)).ToList();

            if (!string.IsNullOrWhiteSpace(status) && status != "Svi")
                rezultat = rezultat.Where(v => v.Status == status).ToList();

            if (!string.IsNullOrWhiteSpace(tipKoriscenja) && tipKoriscenja != "Svi")
                rezultat = rezultat.Where(v => v.TipKoriscenja == tipKoriscenja).ToList();

            if (!string.IsNullOrWhiteSpace(namena) && namena != "Sve")
                rezultat = rezultat.Where(v => v.Namena != null && v.Namena.NamenaVozila == namena).ToList();

            if (!string.IsNullOrWhiteSpace(tipPogona) && tipPogona != "Svi")
            {
                if (tipPogona == "Elektricno")
                    rezultat = rezultat.Where(v => s.Query<ElektricnoVozilo>().Any(e => e.IdVozila == v.IdVozila)).ToList();
                else if (tipPogona == "Hibridno")
                    rezultat = rezultat.Where(v => s.Query<HibridnoVozilo>().Any(h => h.IdVozila == v.IdVozila)).ToList();
                else if (tipPogona == "Klasicno")
                    rezultat = rezultat.Where(v => s.Query<KlasicnoVozilo>().Any(k => k.IdVozila == v.IdVozila)).ToList();
            }

            foreach (Vozilo v in rezultat)
            {
                string tp = "";
                string detalji = "";

                ElektricnoVozilo ev = s.Query<ElektricnoVozilo>().FirstOrDefault(e => e.IdVozila == v.IdVozila);
                HibridnoVozilo hv = s.Query<HibridnoVozilo>().FirstOrDefault(h => h.IdVozila == v.IdVozila);
                KlasicnoVozilo kv = s.Query<KlasicnoVozilo>().FirstOrDefault(k => k.IdVozila == v.IdVozila);

                if (ev != null)
                {
                    tp = "Elektricno";
                    detalji = "Baterija: " + ev.KapacitetBaterije + ", autonomija: " + ev.Autonomija;
                }
                else if (hv != null)
                {
                    tp = "Hibridno";
                    detalji = "Baterija: " + hv.KapacitetBat + ", tip: " + hv.TipHibridnogVozila;
                }
                else if (kv != null)
                {
                    tp = "Klasicno";
                    detalji = "Gorivo: " + kv.TipGoriva + ", potrosnja: " + kv.ProsecnaPotrosnja;
                }

                vozila.Add(new PretrazenoVozilo(v, tp, detalji));
            }

            s.Close();

            return vozila;
        }

        //KVAROVI VOZILA
        public static List<KvaroviView> VratiKvarove(int idVozila) //lista za sve kvarove izabranog vozila
        {
            List<KvaroviView> kvarovi = new List<KvaroviView>();
            ISession s = DataLayer.GetSession();

            IEnumerable<Kvarovi> podaci =
                from k in s.Query<Kvarovi>()
                where k.Vozilo.IdVozila == idVozila
                select k;

            foreach (Kvarovi k in podaci)
                kvarovi.Add(new KvaroviView(k));

            s.Close();
            return kvarovi;
        }

        //SERVISI VOZILA
        public static List<ServisiView> VratiServise(int idVozila)//lista servisa za izabrano vozilo 
        {
            List<ServisiView> servisi = new List<ServisiView>();
            ISession s = DataLayer.GetSession();

            IEnumerable<Servis> podaci =
                from serv in s.Query<Servis>()
                where serv.Vozilo.IdVozila == idVozila
                select serv;

            foreach (Servis serv in podaci)
                servisi.Add(new ServisiView(serv));

            s.Close();
            return servisi;
        }

        private static void KopirajOsnovnePodatkeVozila(Vozilo vozilo, VoziloView dto) //pomoc za tipove pogona
        {
            vozilo.Registracija = dto.Registracija;
            vozilo.VinBroj = dto.VinBr;
            vozilo.Marka = dto.Marka;
            vozilo.ModelVozila = dto.Model;
            vozilo.GodProizvodnje = dto.GodProizvodnje;
            vozilo.DatumNabavke = dto.DatumNabavke;
            vozilo.Status = dto.Status;
            vozilo.TipKoriscenja = dto.TipKoriscenja;
            vozilo.BrSedista = dto.BrSedista;
            vozilo.StanjeEnterijera = dto.StanjeEnterijera;
            vozilo.StanjeEksterijera = dto.StanjeEksterijera;
            vozilo.DodatnaOprema = dto.DodatnaOprema;
        }

        public static string VratiTipPogona(int idVozila) //za dugme za izmenu 
        {
            using ISession s = DataLayer.GetSession();

            if (s.Query<ElektricnoVozilo>()
                .Any(v => v.IdVozila == idVozila))
                return "Elektricno";

            if (s.Query<HibridnoVozilo>()
                .Any(v => v.IdVozila == idVozila))
                return "Hibridno";

            if (s.Query<KlasicnoVozilo>()
                .Any(v => v.IdVozila == idVozila))
                return "Klasicno";

            return "Nepoznato";
        }


        //HIBRIDNO VOZILO
        public static List<HibridnoVoziloView> VratiHVozila() //citanje
        {
            List<HibridnoVoziloView> vozila = new List<HibridnoVoziloView>();

            ISession s = DataLayer.GetSession();

            foreach (HibridnoVozilo hv in s.Query<HibridnoVozilo>())
            {
                vozila.Add(new HibridnoVoziloView(hv));
            }

            s.Close();

            return vozila;
        }

        public static bool DodajHVozilo(HibridnoVoziloView hv) //dodavanje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                HibridnoVozilo novoVozilo = new HibridnoVozilo
                {
                    IdVozila = hv.Id,
                    KapacitetBat = hv.KapacitetBat,
                    TipHibridnogVozila = hv.TipHibridnogVozila
                };

                KopirajOsnovnePodatkeVozila(novoVozilo, hv);

                ITransaction t = s.BeginTransaction();
                s.Save(novoVozilo);
                t.Commit();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Exception trenutna = ex;

                while (trenutna.InnerException != null)
                {
                    trenutna = trenutna.InnerException;
                }

                MessageBox.Show(
                    trenutna.Message,
                    "Greška pri dodavanju vozila",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

        public static HibridnoVoziloView VratiHVozilo(int id) //koga smo izabrali za izmenu
        {
            ISession s = DataLayer.GetSession();

            HibridnoVozilo v = s.Load<HibridnoVozilo>(id);
            HibridnoVoziloView hv = new HibridnoVoziloView(v);

            s.Close();

            return hv;
        }

        public static bool IzmeniHVozilo(HibridnoVoziloView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                HibridnoVozilo vozilo = s.Load<HibridnoVozilo>(v.Id);

                KopirajOsnovnePodatkeVozila(vozilo, v);

                vozilo.KapacitetBat = v.KapacitetBat;
                vozilo.TipHibridnogVozila = v.TipHibridnogVozila;

                ITransaction t = s.BeginTransaction();

                s.Update(vozilo);
                t.Commit();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //KLASICNO VOZILO
        public static List<KlasicnoVoziloView> VratiKVozila() //citanje
        {
            List<KlasicnoVoziloView> vozila = new List<KlasicnoVoziloView>();

            ISession s = DataLayer.GetSession();

            foreach (KlasicnoVozilo kv in s.Query<KlasicnoVozilo>())
            {
                vozila.Add(new KlasicnoVoziloView(kv));
            }

            s.Close();

            return vozila;
        }

        public static bool DodajKVozilo(KlasicnoVoziloView kv) //dodavanje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KlasicnoVozilo novoVozilo = new KlasicnoVozilo
                {
                    IdVozila = kv.Id,
                    Zapremina = kv.Zapremina,
                    ProsecnaPotrosnja = kv.ProsecnaPotrosnja,
                    TipGoriva = kv.TipGoriva
                };

                KopirajOsnovnePodatkeVozila(novoVozilo, kv);

                ITransaction t = s.BeginTransaction();
                s.Save(novoVozilo);
                t.Commit();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Exception trenutna = ex;

                while (trenutna.InnerException != null)
                {
                    trenutna = trenutna.InnerException;
                }

                MessageBox.Show(
                    trenutna.Message,
                    "Greška pri dodavanju vozila",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

        public static KlasicnoVoziloView VratiKVozilo(int id) //koga smo izabrali za izmenu
        {
            ISession s = DataLayer.GetSession();

            KlasicnoVozilo v = s.Load<KlasicnoVozilo>(id);
            KlasicnoVoziloView kv = new KlasicnoVoziloView(v);

            s.Close();

            return kv;
        }

        public static bool IzmeniKVozilo(KlasicnoVoziloView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KlasicnoVozilo vozilo = s.Load<KlasicnoVozilo>(v.Id);

                KopirajOsnovnePodatkeVozila(vozilo, v);

                vozilo.Zapremina = v.Zapremina;
                vozilo.ProsecnaPotrosnja = v.ProsecnaPotrosnja;
                vozilo.TipGoriva = v.TipGoriva;

                ITransaction t = s.BeginTransaction();

                s.Update(vozilo);
                t.Commit();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //ELEKTRICNO VOZILO
        public static List<ElektricnoVoziloView> VratiEVozila() //citanje
        {
            List<ElektricnoVoziloView> vozila = new List<ElektricnoVoziloView>();

            ISession s = DataLayer.GetSession();

            foreach (ElektricnoVozilo ev in s.Query<ElektricnoVozilo>())
            {
                vozila.Add(new ElektricnoVoziloView(ev));
            }

            s.Close();

            return vozila;
        }

        public static bool DodajEVozilo(ElektricnoVoziloView ev) //dodavanje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ElektricnoVozilo novoVozilo = new ElektricnoVozilo
                {
                    IdVozila = ev.Id,
                    KapacitetBaterije = ev.KapacitetBat,
                    NivoNapunjenosti = ev.NivoNapunjenosti,
                    TipPunjenja = ev.TipPunjenja,
                    Autonomija = ev.Autonomija,
                    BrCiklusaPunjenja = ev.BrCiklusaPunjenja
                };

                KopirajOsnovnePodatkeVozila(novoVozilo, ev);

                ITransaction t = s.BeginTransaction();
                s.Save(novoVozilo);
                t.Commit();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Exception trenutna = ex;

                while (trenutna.InnerException != null)
                {
                    trenutna = trenutna.InnerException;
                }

                MessageBox.Show(
                    trenutna.Message,
                    "Greška pri dodavanju vozila",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

        public static ElektricnoVoziloView VratiEVozilo(int id) //koga smo izabrali za izmenu
        {
            ISession s = DataLayer.GetSession();

            ElektricnoVozilo v = s.Load<ElektricnoVozilo>(id);
            ElektricnoVoziloView ev = new ElektricnoVoziloView(v);

            s.Close();

            return ev;
        }

        public static bool IzmeniEVozilo(ElektricnoVoziloView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ElektricnoVozilo vozilo = s.Load<ElektricnoVozilo>(v.Id);

                KopirajOsnovnePodatkeVozila(vozilo, v);

                vozilo.KapacitetBaterije = v.KapacitetBat;
                vozilo.NivoNapunjenosti = v.NivoNapunjenosti;
                vozilo.TipPunjenja = v.TipPunjenja;
                vozilo.Autonomija = v.Autonomija;
                vozilo.BrCiklusaPunjenja = v.BrCiklusaPunjenja;

                ITransaction t = s.BeginTransaction();

                s.Update(vozilo);
                t.Commit();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion

        #region RezervacijaIVoznja

        public static List<RezervacijaView> VratiRezervacije() //citanje
        {
            List<RezervacijaView> rez = new List<RezervacijaView>();

            ISession s = DataLayer.GetSession();

            foreach (Rezervacija r in s.Query<Rezervacija>())
            {
                rez.Add(new RezervacijaView(r));
            }

            s.Close();

            return rez;
        }

        public static bool DodajRezervaciju(RezervacijaView r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Rezervacija novaRez = new Rezervacija
                {
                    IdRezervacije = r.Id,

                    Korisnik = s.Load<Korisnik>(r.IdKorisnika),
                    FizickaLica = s.Load<FizickaLica>(r.IdVozaca),
                    Vozilo = s.Load<Vozilo>(r.IdVozila),

                    PlaniranaLokacijaPreuzimanja =
                        r.PlaniranaLokacijaPreuzimanja,

                    PlaniranaLokacijaVracanja =
                        r.PlaniranaLokacijaVracanja,

                    Tip = r.Tip,
                    Status = r.Status,
                    PlaniranoVremePocetka = r.PlaniranoVremePocetka,
                    PlaniranoVremeZavrsetka = r.PlaniranoVremeZavrsetka
                };

                ITransaction t = s.BeginTransaction();

                s.Save(novaRez);

                t.Commit();
                s.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static RezervacijaView VratiRezervaciju(int id) //koga smo izabrali za izmenu
        {
            ISession s = DataLayer.GetSession();

            Rezervacija r = s.Load<Rezervacija>(id);
            RezervacijaView rez = new RezervacijaView(r);

            s.Close();

            return rez;
        }

        public static bool IzmeniRezervaciju(RezervacijaView r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Rezervacija rezervacija =
                    s.Load<Rezervacija>(r.Id);

                rezervacija.Korisnik =
                    s.Load<Korisnik>(r.IdKorisnika);

                rezervacija.FizickaLica =
                    s.Load<FizickaLica>(r.IdVozaca);

                rezervacija.Vozilo =
                    s.Load<Vozilo>(r.IdVozila);

                rezervacija.PlaniranaLokacijaPreuzimanja =
                    r.PlaniranaLokacijaPreuzimanja;

                rezervacija.PlaniranaLokacijaVracanja =
                    r.PlaniranaLokacijaVracanja;

                rezervacija.Tip = r.Tip;
                rezervacija.Status = r.Status;
                rezervacija.PlaniranoVremePocetka =
                    r.PlaniranoVremePocetka;

                rezervacija.PlaniranoVremeZavrsetka =
                    r.PlaniranoVremeZavrsetka;

                ITransaction t = s.BeginTransaction();

                s.Update(rezervacija);

                t.Commit();
                s.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void obrisiRezervacija(int id) //brisanje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IznajmljivanjeVozila.Entiteti.Rezervacija r = s.Load<IznajmljivanjeVozila.Entiteti.Rezervacija>(id);

                s.Delete(r);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DostupnostVozilaView ProveriDostupnostVozila(
            int idVozila,
            DateTime pocetak,
            DateTime zavrsetak,
            int? idRezervacijeZaIzuzimanje = null)
        {
            DostupnostVozilaView rezultat =
                new DostupnostVozilaView
                {
                    IdVozila = idVozila,
                    Dostupno = false
                };

            if (zavrsetak <= pocetak)
            {
                rezultat.Poruka =
                    "Vreme završetka mora biti nakon vremena početka.";

                return rezultat;
            }

            ISession s = DataLayer.GetSession();

            try
            {
                Vozilo vozilo = s.Get<Vozilo>(idVozila);

                if (vozilo == null)
                {
                    rezultat.Poruka =
                        "Izabrano vozilo ne postoji u bazi.";

                    return rezultat;
                }

                if (!string.Equals(
                        vozilo.Status,
                        "Aktivno",
                        StringComparison.OrdinalIgnoreCase))
                {
                    rezultat.Poruka =
                        $"Vozilo nije dostupno jer ima status " +
                        $"\"{vozilo.Status}\".";

                    return rezultat;
                }

                IQueryable<Rezervacija> upit =
                    s.Query<Rezervacija>()
                        .Where(r =>
                            r.Vozilo != null &&
                            r.Vozilo.IdVozila == idVozila &&
                            r.Status == "Aktivna" &&
                            pocetak < r.PlaniranoVremeZavrsetka &&
                            zavrsetak > r.PlaniranoVremePocetka
                        );

                if (idRezervacijeZaIzuzimanje.HasValue)
                {
                    int idZaIzuzimanje =
                        idRezervacijeZaIzuzimanje.Value;

                    upit = upit.Where(
                        r => r.IdRezervacije != idZaIzuzimanje
                    );
                }

                Rezervacija konfliktnaRezervacija =
                    upit
                        .OrderBy(r => r.PlaniranoVremePocetka)
                        .FirstOrDefault();

                if (konfliktnaRezervacija != null)
                {
                    rezultat.Dostupno = false;

                    rezultat.IdKonfliktneRezervacije =
                        konfliktnaRezervacija.IdRezervacije;

                    rezultat.ZauzetoOd =
                        konfliktnaRezervacija
                            .PlaniranoVremePocetka;

                    rezultat.ZauzetoDo =
                        konfliktnaRezervacija
                            .PlaniranoVremeZavrsetka;

                    rezultat.Poruka =
                        $"Vozilo nije dostupno. " +
                        $"Rezervacija " +
                        $"{konfliktnaRezervacija.IdRezervacije} " +
                        $"traje od " +
                        $"{konfliktnaRezervacija.PlaniranoVremePocetka:dd.MM.yyyy HH:mm} " +
                        $"do " +
                        $"{konfliktnaRezervacija.PlaniranoVremeZavrsetka:dd.MM.yyyy HH:mm}.";

                    return rezultat;
                }

                rezultat.Dostupno = true;

                rezultat.Poruka =
                    $"Vozilo je dostupno u periodu od " +
                    $"{pocetak:dd.MM.yyyy HH:mm} do " +
                    $"{zavrsetak:dd.MM.yyyy HH:mm}.";

                return rezultat;
            }
            catch (Exception ex)
            {
                rezultat.Dostupno = false;
                rezultat.Poruka =
                    "Greška prilikom provere dostupnosti: " +
                    ex.Message;

                return rezultat;
            }
            finally
            {
                s.Close();
            }
        }

        public static List<VoznjeView> VratiSveVoznje() //citanje
        {
            List<VoznjeView> voznje = new List<VoznjeView>();

            ISession s = DataLayer.GetSession();

            foreach (Voznja v in s.Query<Voznja>())
            {
                voznje.Add(new VoznjeView(v));
            }

            s.Close();

            return voznje;
        }

        public static bool DodajVoznju(VoznjeView v) //dodavanje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja novaVoznja= new Voznja
                {
                    IdVoznje = v.Id,
                    VremePocetka = v.VremePocetka,
                    VremeZavrsetka = v.VremeZavrsetka,
                    Km = v.Kilometraza,
                    Trajanje = v.Trajanje,
                    PocetniNivoGorIliBat = v.PocetniNivoGorIliBat,
                    PocetnaLokacija = v.PocetnaLokacija,
                    ZavrsnaLokacija = v.ZavrsnaLokacija,
                    ObracunataCena = v.ObracunataCena,
                    DodatneNaknade =v.DodatneNaknade
                };

                ITransaction t = s.BeginTransaction();
                s.Save(novaVoznja);
                t.Commit();

                s.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static VoznjeView VratiVoznju(int id) //koga smo izabrali za izmenu
        {
            ISession s = DataLayer.GetSession();

            Voznja v = s.Load<Voznja>(id);
            VoznjeView voznja = new VoznjeView(v);

            s.Close();

            return voznja;
        }

        public static bool IzmeniVoznju(VoznjeView v) //izmena
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja voznja = s.Load<Voznja>(v.Id);

                voznja.VremePocetka = v.VremePocetka;
                voznja.VremeZavrsetka = v.VremeZavrsetka;
                voznja.Km = v.Kilometraza;
                voznja.Trajanje = v.Trajanje;
                voznja.PocetniNivoGorIliBat = v.PocetniNivoGorIliBat;
                voznja.PocetnaLokacija = v.PocetnaLokacija;
                voznja.ZavrsnaLokacija = v.ZavrsnaLokacija;
                voznja.ObracunataCena = v.ObracunataCena;
                voznja.DodatneNaknade = v.DodatneNaknade;

                ITransaction t = s.BeginTransaction();
                s.Update(voznja);
                t.Commit();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void obrisiVoznju(int id) //brisanje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IznajmljivanjeVozila.Entiteti.Voznja v = s.Load<IznajmljivanjeVozila.Entiteti.Voznja>(id);

                s.Delete(v);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<KorisnikVoznjaCombo> VratiKorisnikaZaCombo()//za voznju - korisnik koji je narucio rezervaicju
        {
            List<KorisnikVoznjaCombo> korisnici = new List<KorisnikVoznjaCombo>();

            ISession s = DataLayer.GetSession();

            foreach (Korisnik k in s.Query<Korisnik>())
            {
                korisnici.Add(new KorisnikVoznjaCombo(k));
            }

            s.Close();

            return korisnici;
        }

        public static List<VoziloVoznjaCombo> VratiVoziloZaCombo()//za voznju koje ce se koristiti
        {
            List<VoziloVoznjaCombo> vozila = new List<VoziloVoznjaCombo>();

            ISession s = DataLayer.GetSession();

            foreach (Vozilo v in s.Query<Vozilo>())
            {
                vozila.Add(new VoziloVoznjaCombo(v));
            }

            s.Close();

            return vozila;
        }

        public static List<VozacCombo> VratiVozacaCombo()//vozac za voznju koja se rezervisala 
        {
            List<VozacCombo> vozac = new List<VozacCombo>();

            ISession s = DataLayer.GetSession();

            foreach (FizickaLica fl in s.Query<FizickaLica>())
            {
                vozac.Add(new VozacCombo(fl));
            }

            s.Close();

            return vozac;
        }

        public static List<DogadjajiView>VratiSveDogadjaje()
        {
            List<DogadjajiView> rezultat =
                new List<DogadjajiView>();

            using ISession s = DataLayer.GetSession();

            List<Dogadjaji> dogadjaji =
                s.Query<Dogadjaji>().ToList();

            foreach (Dogadjaji d in dogadjaji)
            {
                Voznja voznja =
                    s.Query<Voznja>()
                        .FirstOrDefault(v =>
                            v.Dogadjaji != null &&
                            v.Dogadjaji.Id == d.Id
                        );

                int idVoznje =
                    voznja?.IdVoznje ?? 0;

                rezultat.Add(
                    new DogadjajiView(
                        d,
                        idVoznje
                    )
                );
            }

            return rezultat;
        }

        public static bool DodajDogadjaj(
      DogadjajiView d)
        {
            using ISession s = DataLayer.GetSession();
            using ITransaction t = s.BeginTransaction();

            try
            {
                Voznja voznja =
                    s.Get<Voznja>(d.IdVoznje);

                if (voznja == null)
                {
                    MessageBox.Show(
                        "Izabrana vožnja ne postoji."
                    );

                    return false;
                }

                if (voznja.Dogadjaji != null)
                {
                    MessageBox.Show(
                        "Izabrana vožnja već ima evidentiran događaj."
                    );

                    return false;
                }

                Dogadjaji noviDogadjaj =
                    new Dogadjaji
                    {
                        Id = d.Id,
                        NagloKocenje =
                            d.NagloKocenje,
                        PrekoracenjeBrzine =
                            d.PrekoracenjeBrzine,
                        DuzeZadrzavanje =
                            d.DuzeZadrzavanje,
                        NeovlasceniIzlazak =
                            d.NeovlasceniIzlazak,
                        Sudar = d.Sudar
                    };

                s.Save(noviDogadjaj);

                voznja.Dogadjaji =
                    noviDogadjaj;

                t.Commit();

                return true;
            }
            catch (Exception ex)
            {
                if (t.IsActive)
                {
                    t.Rollback();
                }

                MessageBox.Show(
                    ex.InnerException?.Message ??
                    ex.Message
                );

                return false;
            }
        }

        public static DogadjajiView VratiDogadjaj(int id)
        {
            using ISession s = DataLayer.GetSession();

            Dogadjaji dogadjaj =
                s.Get<Dogadjaji>(id);

            if (dogadjaj == null)
            {
                return null;
            }

            Voznja voznja =
                s.Query<Voznja>()
                    .FirstOrDefault(v =>
                        v.Dogadjaji != null &&
                        v.Dogadjaji.Id == id
                    );

            return new DogadjajiView(
                dogadjaj,
                voznja?.IdVoznje ?? 0
            );
        }

        public static bool IzmeniDogadjaj(
     DogadjajiView d)
        {
            using ISession s = DataLayer.GetSession();
            using ITransaction t = s.BeginTransaction();

            try
            {
                Dogadjaji dogadjaj =
                    s.Get<Dogadjaji>(d.Id);

                if (dogadjaj == null)
                {
                    MessageBox.Show(
                        "Događaj ne postoji."
                    );

                    return false;
                }

                Voznja staraVoznja =
                    s.Query<Voznja>()
                        .FirstOrDefault(v =>
                            v.Dogadjaji != null &&
                            v.Dogadjaji.Id == d.Id
                        );

                Voznja novaVoznja =
                    s.Get<Voznja>(d.IdVoznje);

                if (novaVoznja == null)
                {
                    MessageBox.Show(
                        "Izabrana vožnja ne postoji."
                    );

                    return false;
                }

                if (novaVoznja.Dogadjaji != null &&
                    novaVoznja.Dogadjaji.Id != d.Id)
                {
                    MessageBox.Show(
                        "Izabrana vožnja već ima drugi događaj."
                    );

                    return false;
                }

                dogadjaj.NagloKocenje =
                    d.NagloKocenje;

                dogadjaj.PrekoracenjeBrzine =
                    d.PrekoracenjeBrzine;

                dogadjaj.DuzeZadrzavanje =
                    d.DuzeZadrzavanje;

                dogadjaj.NeovlasceniIzlazak =
                    d.NeovlasceniIzlazak;

                dogadjaj.Sudar =
                    d.Sudar;

                if (staraVoznja != null &&
                    staraVoznja.IdVoznje !=
                    novaVoznja.IdVoznje)
                {
                    staraVoznja.Dogadjaji = null;
                }

                novaVoznja.Dogadjaji =
                    dogadjaj;

                t.Commit();

                return true;
            }
            catch (Exception ex)
            {
                if (t.IsActive)
                {
                    t.Rollback();
                }

                MessageBox.Show(
                    ex.InnerException?.Message ??
                    ex.Message
                );

                return false;
            }
        }

        public static List<VoznjaCombo>VratiVoznjeZaCombo() //za dogadjaj formu
        {
            List<VoznjaCombo> rezultat =
                new List<VoznjaCombo>();

            using ISession s = DataLayer.GetSession();

            List<Voznja> voznje =
                s.Query<Voznja>()
                    .OrderBy(v => v.IdVoznje)
                    .ToList();

            foreach (Voznja v in voznje)
            {
                rezultat.Add(
                    new VoznjaCombo(v)
                );
            }

            return rezultat;
        }

        public static List<SteteView> VratiStete() //citanje
        {
            List<SteteView> stete = new List<SteteView>();

            ISession s = DataLayer.GetSession();

            foreach (Steta steta in s.Query<Steta>())
            {
                stete.Add(new SteteView(steta));
            }

            s.Close();

            return stete;
        }

        public static bool DodajStetu(SteteView steta)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Steta novaSteta = new Steta
                {
                    IdStete = steta.Id,
                    Foto = steta.Fotografije,
                    Zapisnici = steta.Zapisnici,
                    OsiguravajuceKuce = steta.OsiguravajuceKuce,
                    ProcenaStete = steta.ProcenaStete,
                    Odgovornost = steta.Odgovornost,

                    Voznja =s.Load<Voznja>(steta.IdVoznje)
                };

                ITransaction t = s.BeginTransaction();

                s.Save(novaSteta);

                t.Commit();
                s.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static SteteView VratiStetu(int id) //koga smo izabrali za izmenu
        {
            ISession s = DataLayer.GetSession();

            Steta steta = s.Load<Steta>(id);
            SteteView st = new SteteView(steta);

            s.Close();

            return st;
        }

        public static bool IzmeniStetu(
       SteteView stetaView)
        {
            try
            {
                using ISession s =
                    DataLayer.GetSession();

                Steta steta =
                    s.Get<Steta>(
                        stetaView.Id
                    );

                if (steta == null)
                {
                    MessageBox.Show(
                        "Šteta ne postoji."
                    );

                    return false;
                }

                Voznja voznja =
                    s.Get<Voznja>(
                        stetaView.IdVoznje
                    );

                if (voznja == null)
                {
                    MessageBox.Show(
                        "Izabrana vožnja ne postoji."
                    );

                    return false;
                }

                steta.Foto =
                    stetaView.Fotografije;

                steta.Zapisnici =
                    stetaView.Zapisnici;

                steta.OsiguravajuceKuce =
                    stetaView.OsiguravajuceKuce;

                steta.ProcenaStete =
                    stetaView.ProcenaStete;

                steta.Odgovornost =
                    stetaView.Odgovornost;

                steta.Voznja = voznja;

                using ITransaction t =
                    s.BeginTransaction();

                s.Update(steta);

                t.Commit();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.InnerException?.Message ??
                    ex.Message
                );

                return false;
            }
        }

        public static List<SluzbeneVoznjeView> VratiSluzbenuVoznju() //citanje
        {
            List<SluzbeneVoznjeView> sluzbenaVoznja = new List<SluzbeneVoznjeView>();

            ISession s = DataLayer.GetSession();

            foreach (SluzbenaVoznja sv in s.Query<SluzbenaVoznja>())
            {
                sluzbenaVoznja.Add(new SluzbeneVoznjeView(sv));
            }

            s.Close();

            return sluzbenaVoznja;
        }

        public static List<OvlascenoLiceCombo> VratiOvlascenaLicaZaCombo()
        {
            List<OvlascenoLiceCombo> lica = new List<OvlascenoLiceCombo>();

            try
            {
                ISession s = DataLayer.GetSession();

                foreach (FizickaLica fl in s.Query<FizickaLica>())
                {
                    lica.Add(new OvlascenoLiceCombo(fl));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lica;
        }

        public static List<SluzbeneVoznjeView>
    VratiSluzbeneVoznjeOvlascenogLica(int idOvlascenogLica)
        {
            List<SluzbeneVoznjeView> voznje =
                new List<SluzbeneVoznjeView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<SluzbenaVoznja> rezultat =
                    from sv in s.Query<SluzbenaVoznja>()
                    where sv.FizickaLica.IdFLica == idOvlascenogLica
                    select sv;

                foreach (SluzbenaVoznja sv in rezultat)
                {
                    voznje.Add(new SluzbeneVoznjeView(sv));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return voznje;
        }

        #endregion

    }
}
