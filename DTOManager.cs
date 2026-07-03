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

        public static void obrisiKorisnika(int id) //brisanje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IznajmljivanjeVozila.Entiteti.Korisnik k = s.Load<IznajmljivanjeVozila.Entiteti.Korisnik>(id);

                s.Delete(k);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


        public static List<PretrazenoVozilo> PretraziVozila(
            string marka,
            string model,
            string status,
            string tipKoriscenja,
            string namena,
            string tipPogona,
            string dopuna,
            string tipGoriva)
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

            if (!string.IsNullOrWhiteSpace(tipGoriva) && tipGoriva != "Svi")
            {
                rezultat = rezultat.Where(v =>
                    s.Query<KlasicnoVozilo>()
                     .Any(k => k.IdVozila == v.IdVozila && k.TipGoriva == tipGoriva)
                ).ToList();
            }

            if (!string.IsNullOrWhiteSpace(dopuna) && dopuna != "Sve")
            {
                rezultat = rezultat.Where(v =>
                    s.Query<PunjenjeIliTocenjeGoriva>()
                     .Any(p => p.Vozilo.IdVozila == v.IdVozila && p.TipDopune == dopuna)
                ).ToList();
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

        public static List<DogadjajiView> VratiSveDogadjaje() //citanje
        {
            List<DogadjajiView> dogadjaj = new List<DogadjajiView>();

            ISession s = DataLayer.GetSession();

            foreach (Dogadjaji d in s.Query<Dogadjaji>())
            {
                dogadjaj.Add(new DogadjajiView(d));
            }

            s.Close();

            return dogadjaj;
        }

        public static bool DodajDogadjaj(DogadjajiView d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dogadjaji noviDogadjaj = new Dogadjaji
                {
                    Id = d.Id,
                    NagloKocenje = d.NagloKocenje,
                    PrekoracenjeBrzine = d.PrekoracenjeBrzine,
                    DuzeZadrzavanje = d.DuzeZadrzavanje,
                    NeovlasceniIzlazak = d.NeovlasceniIzlazak,
                    Sudar = d.Sudar
                };

                ITransaction t = s.BeginTransaction();

                s.Save(noviDogadjaj);

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

        public static DogadjajiView VratiDogadjaj(int id) //koga smo izabrali za izmenu
        {
            ISession s = DataLayer.GetSession();

            Dogadjaji d = s.Load<Dogadjaji>(id);
            DogadjajiView rez = new DogadjajiView(d);

            s.Close();

            return rez;
        }

        public static bool IzmeniDogadjaj(DogadjajiView d) //izmena
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dogadjaji dogadjaji = s.Load<Dogadjaji>(d.Id);

                dogadjaji.NagloKocenje = d.NagloKocenje;
                dogadjaji.PrekoracenjeBrzine = d.PrekoracenjeBrzine;
                dogadjaji.DuzeZadrzavanje = d.DuzeZadrzavanje;
                dogadjaji.NeovlasceniIzlazak = d.NeovlasceniIzlazak;
                dogadjaji.Sudar = d.Sudar;

                ITransaction t = s.BeginTransaction();
                s.Update(dogadjaji);
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
                    Odgovornost = steta.Odgovornost
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

        public static bool IzmeniStetu(SteteView steta)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Steta st = s.Load<Steta>(steta.Id);

                steta.Fotografije = st.Foto;
                steta.Zapisnici = st.Zapisnici;
                steta.OsiguravajuceKuce = st.OsiguravajuceKuce;
                steta.ProcenaStete = st.ProcenaStete;
                steta.Odgovornost = st.Odgovornost;

                ITransaction t = s.BeginTransaction();

                s.Update(steta);

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
