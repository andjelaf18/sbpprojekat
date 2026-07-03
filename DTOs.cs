using IznajmljivanjeVozila.Entiteti;
using IznajmljivanjeVozila.Mapiranja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila
{

    #region Korisnik
    public class KorisnikView
    {
        public int Id { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string StatusNaloga { get; set; }
        public string NacinVerifikacije { get; set; }

        public KorisnikView()
        {
        }

        public KorisnikView(Korisnik k)
        {
            Id = k.Id;
            Adresa = k.Adresa;
            BrojTelefona = k.BrojTelefona;
            Email = k.Email;
            DatumRegistracije = k.DatumRegistracije;
            StatusNaloga = k.StatusNaloga;
            NacinVerifikacije = k.NacinVerifikacije;
        }
    }

    public class PLicaView
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

        public string MatBr { get; set; }

        public string Sediste { get; set; }

        public string KontaktOsoba { get; set; }

        public string UgovorniUslovi { get; set; }

        public int Pib { get; set; }

        public PLicaView()
        {
        }

        public PLicaView(PravnaLica pl)
        {
            Id = pl.IdPLica;
            Naziv = pl.Naziv;
            MatBr = pl.MatBr;
            Sediste = pl.Sediste;
            KontaktOsoba = pl.KontaktOsoba;
            UgovorniUslovi = pl.UgovorniUslovi;
            Pib = pl.Pib;
        }

    }

    public class NacinPlacanjaView
    {
        public int Id { get; set; }

        public string TipPlacanja { get; set; }

        public string Status { get; set; }

        public DateTime DatumOgranicenja { get; set; }

        public int IdKorisnika { get; set; }

        public NacinPlacanjaView()
        {

        }

        public NacinPlacanjaView(NacinPlacanja n)
        {
            Id = n.IdPlacanja;
            TipPlacanja = n.TipPlacanja;
            Status = n.Status;
            DatumOgranicenja = n.DatumDodavanjaOgranicenja;
            IdKorisnika = n.Korisnik.Id;
        }

    }

    public class KorisnikCombo //za nacin placanja formu
    {
        public int Id { get; set; }
        public string Prikaz { get; set; }

        public KorisnikCombo(Korisnik k)
        {
            Id = k.Id;
            Prikaz = k.Id + " - " + k.Email;
        }
    }
    #endregion


    #region Vozilo
    public class VoziloView
    {
        public int Id { get; set; }

        public string Registracija { get; set; }

        public string VinBr { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public int GodProizvodnje { get; set; }

        public DateTime DatumNabavke { get; set; }

        public string Status { get; set; }

        public string TipKoriscenja { get; set; }

        public int BrSedista { get; set; }

        public string StanjeEnterijera { get; set; }

        public string StanjeEksterijera { get; set; }

        public string DodatnaOprema { get; set; }

        public VoziloView()
        {

        }

        public VoziloView(Vozilo v)
        {
            Id = v.IdVozila;
            Registracija = v.Registracija;
            VinBr = v.VinBroj;
            Marka = v.Marka;
            Model = v.ModelVozila;
            GodProizvodnje = v.GodProizvodnje;
            DatumNabavke = v.DatumNabavke;
            Status = v.Status;
            TipKoriscenja = v.TipKoriscenja;
            BrSedista = v.BrSedista;
            StanjeEnterijera = v.StanjeEnterijera;
            StanjeEksterijera = v.StanjeEksterijera;
            DodatnaOprema = v.DodatnaOprema;
        }

    }

    public class KvaroviView
    {
        public int Id { get; set; }

        public string PrijavioKvar { get; set; }

        public string OpisProblema { get; set; }

        public string ProcenaOzbiljnosti { get; set; }

        public string Status { get; set; }

        public DateTime DatumPrijave { get; set; }

        public DateTime DatumOtklanjanja { get; set; }

        public KvaroviView()
        {

        }

        public KvaroviView(Kvarovi k)
        {
            Id = k.IdKvara;
            PrijavioKvar = k.PrijavioKvar;
            OpisProblema = k.OpisProblema;
            ProcenaOzbiljnosti = k.ProcenaOzbiljnosti;
            Status = k.Status;
            DatumPrijave = k.DatumPrijave;
            DatumOtklanjanja = k.DatumOtklanjanja;
        }
    }


    public class ServisiView
    {
        public int Id { get; set; }

        public string ServisniCentar { get; set; }

        public DateTime DatumPrijema { get; set; }

        public DateTime DatumZavrsetka { get; set; }

        public string OpisRadova { get; set; }

        public string ZamenjeniDelovi { get; set; }

        public string Status { get; set; }

        public string Tip { get; set; }

        public double Troskovi { get; set; }

        public ServisiView()
        {

        }

        public ServisiView(Servis s)
        {
            Id = s.IdServisa;
            ServisniCentar = s.ServisniCentar;
            DatumPrijema = s.DatumPrijema;
            DatumZavrsetka = s.DatumZavrsetka;
            OpisRadova = s.OpisRadova;
            ZamenjeniDelovi = s.ZamenjeniDelovi;
            Status = s.Status;
            Tip = s.TipServisa;
            Troskovi = s.Troskovi;
        }
    }

    public class PretrazenoVozilo
    {
        public int Id { get; set; } //?

        public string Marka { get; set; }

        public string Model { get; set; }

        public string Status { get; set; }

        public string TipKoriscenja { get; set; }

        public int BrSedista { get; set; }

        public string DodatnaOprema { get; set; }

        public string NamenaVozila { get; set; }

        public string TipPogona { get; set; }

        public string Detalji { get; set; }



        public PretrazenoVozilo()
        {

        }

        public PretrazenoVozilo(Vozilo v, string tipPogona, string detalji)
        {
            Id = v.IdVozila;
            Marka = v.Marka;
            Model = v.ModelVozila;
            Status = v.Status;
            TipKoriscenja = v.TipKoriscenja;
            BrSedista = v.BrSedista;
            DodatnaOprema = v.DodatnaOprema;
            NamenaVozila = v.Namena != null ? v.Namena.NamenaVozila : "";

            TipPogona = tipPogona;
            Detalji = detalji;


        }

    }

    #endregion

    #region RezervacijaIVoznja
    public class RezervacijaView
    {
        public int Id { get; set; }

        public int IdKorisnika { get; set; }

        public int IdVozaca { get; set; }

        public int IdVozila { get; set; }

        public string PlaniranaLokacijaPreuzimanja { get; set; }

        public string PlaniranaLokacijaVracanja { get; set; }

        public string Tip { get; set; }

        public string Status { get; set; }

        public DateTime PlaniranoVremePocetka { get; set; } 

        public DateTime PlaniranoVremeZavrsetka { get; set; } 

        public RezervacijaView()
        {

        }

        public RezervacijaView(Rezervacija r)
        {
            Id = r.IdRezervacije;

            IdKorisnika = r.Korisnik?.Id ?? 0;
            IdVozaca = r.FizickaLica?.IdFLica ?? 0;
            IdVozila = r.Vozilo?.IdVozila ?? 0;

            PlaniranaLokacijaPreuzimanja = r.PlaniranaLokacijaPreuzimanja;
            PlaniranaLokacijaVracanja = r.PlaniranaLokacijaVracanja;
            Tip = r.Tip;
            Status = r.Status;
            PlaniranoVremePocetka = r.PlaniranoVremePocetka;
            PlaniranoVremeZavrsetka = r.PlaniranoVremeZavrsetka;
        }
    }

    public class DogadjajiView
    {
        public int Id { get; set; }

        public string NagloKocenje { get; set; }

        public string PrekoracenjeBrzine { get; set; }

        public string DuzeZadrzavanje { get; set; }

        public string NeovlasceniIzlazak { get; set; }

        public string Sudar { get; set; }

        public DogadjajiView()
        {

        }

        public DogadjajiView(Dogadjaji d)
        {
            Id =d.Id;
            NagloKocenje = d.NagloKocenje;
            PrekoracenjeBrzine = d.PrekoracenjeBrzine;
            DuzeZadrzavanje = d.DuzeZadrzavanje;
            NeovlasceniIzlazak = d.NeovlasceniIzlazak;
            Sudar = d.Sudar;
        }
    }

    public class SteteView
    {
        public int Id { get; set; }

        public string Fotografije { get; set; }

        public string Zapisnici { get; set; }

        public string OsiguravajuceKuce { get; set; }

        public string ProcenaStete { get; set; }

        public string Odgovornost { get; set; }

        public SteteView()
        {

        }

        public SteteView(Steta s)
        {
            Id = s.IdStete;
            Fotografije = s.Foto;
            Zapisnici = s.Zapisnici;
            OsiguravajuceKuce = s.OsiguravajuceKuce;
            ProcenaStete = s.ProcenaStete;
            Odgovornost = s.Odgovornost;
        }

    }

    public class VoznjeView
    {
        public int Id { get; set; }

        public DateTime VremePocetka { get; set; } 

        public DateTime VremeZavrsetka { get; set; }  

        public decimal Kilometraza { get; set; }

        public decimal Trajanje { get; set; }

        public decimal PocetniNivoGorIliBat { get; set; }

        public string PocetnaLokacija { get; set; }

        public string ZavrsnaLokacija { get; set; }

        public double ObracunataCena { get; set; }

        public double DodatneNaknade { get; set; }

        public VoznjeView()
        {

        }

        public VoznjeView(Voznja v)
        {
            Id = v.IdVoznje;
            VremePocetka = v.VremePocetka;
            VremeZavrsetka = v.VremeZavrsetka;
            Kilometraza = v.Km;
            Trajanje = v.Trajanje;
            PocetniNivoGorIliBat = v.PocetniNivoGorIliBat;
            PocetnaLokacija = v.PocetnaLokacija;
            ZavrsnaLokacija = v.ZavrsnaLokacija;
            ObracunataCena = v.ObracunataCena;
            DodatneNaknade = v.DodatneNaknade;
        }

    }

    public class KorisnikVoznjaCombo //za voznju formu
    {
        public int Id { get; set; }
        public string Prikaz { get; set; }

        public KorisnikVoznjaCombo(Korisnik k)
        {
            Id = k.Id;
            Prikaz = k.Id + " - " + k.Email;
        }
    }

    public class VoziloVoznjaCombo //za voznja formu
    {
        public int Id { get; set; }
        public string Prikaz { get; set; }

        public VoziloVoznjaCombo(Vozilo v)
        {
            Id = v.IdVozila;
            Prikaz = $"{v.IdVozila} - {v.Marka} {v.ModelVozila} ({v.Registracija})";
        }
    }

    public class VozacCombo //za formu voznja
    {
        public int Id { get; set; }
        public string Podaci { get; set; }

        public VozacCombo(FizickaLica fl)
        {
            Id = fl.IdFLica;
            Podaci =
                $"{fl.IdFLica} - {fl.Ime} {fl.Prezime}, dozvola: {fl.BrVozackeDozvole}";
        }
    }

    public class SluzbeneVoznjeView
    {
        public int Id { get; set; }

        public string Razlog { get; set; }

        public SluzbeneVoznjeView()
        {

        }

        public SluzbeneVoznjeView(SluzbenaVoznja svoznja)
        {
            Id = svoznja.IdSVoznje;
            Razlog = svoznja.Razlog;
        }
    }

    public class OvlascenoLiceCombo //za sluzbene voznje formu
    {
        public int Id { get; set; }
        public string Podaci { get; set; }

        public OvlascenoLiceCombo(FizickaLica fl)
        {
            Id = fl.IdFLica;
            Podaci = $"{fl.IdFLica} - {fl.Ime} {fl.Prezime}";
        }
    }

    public class FizickoLiceView//za sluzbenu voznju - ovlasceno lice
    {
        public int Id { get; set; }

        public string Ime { get; set; }

        public string Jmbg { get; set; }

        public string Prezime { get; set; }

        public DateTime DatumIzdavanja { get; set; }

        public string KategorijaDozvole { get; set; }

        public int BrVozackeDozvole { get; set; }

        public DateTime DatumIsteka { get; set; }

        public FizickoLiceView(FizickaLica fl)
        {
            Id = fl.IdFLica;
            Ime = fl.Ime;
            Jmbg = fl.Jmbg;
            Prezime = fl.Prezime;
            DatumIzdavanja = fl.DatumIzdavanja;
            KategorijaDozvole = fl.KategorijaDozvole;
            BrVozackeDozvole = fl.BrVozackeDozvole;
            DatumIsteka = fl.DatumIsteka;
        }
    }

    #endregion
}