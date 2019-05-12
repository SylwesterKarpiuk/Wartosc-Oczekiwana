using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wartosc_Oczekiwana
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies;
        double sKrolikow, sOwiec, sSwin, sKrow, sKoni;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LiczButton_Click(object sender, RoutedEventArgs e)
        {
            lKrolikow = Convert.ToDouble(this.iKrolikow.Text);
            lOwiec = Convert.ToDouble(this.iOwiec.Text);
            lSwin = Convert.ToDouble(this.iSwin.Text);
            lKrow = Convert.ToDouble(this.iKrow.Text);
            lKoni = Convert.ToDouble(this.iKoni.Text);
            mPies = Convert.ToDouble(this.iMPies.Text);
            dPies = Convert.ToDouble(this.iDPies.Text);

            sKrolikow = Convert.ToDouble(this.dKrolikow.Text);
            sOwiec = Convert.ToDouble(this.dOwiec.Text);
            sSwin = Convert.ToDouble(this.dSwin.Text);
            sKrow = Convert.ToDouble(this.dKrow.Text);
            sKoni = Convert.ToDouble(this.dKoni.Text);
    
            //this.Wynik.Text = LiczZeWzoru(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies).ToString();
            this.wartoscDwaKroliki.Text = WartoscDwaKroliki(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKrolikow).ToString();
            this.wartoscKrolikIOwca.Text = WartoscKrólikIOwca(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec, sKrolikow).ToString();
            this.wartoscKrolikISwinia.Text = WartoscKrólikISwinia(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sSwin, sKrolikow).ToString();
            this.wartoscKrolikIKrowa.Text = WartoscKrólikIKrowa(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKrow, sKrolikow).ToString();
            this.wartoscKrolikIKon.Text = WartoscKrólikIKon(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKoni, sKrolikow).ToString();
            this.wartoscKrolikILis.Text = WartoscKrólikILis(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKrolikow).ToString();
            this.wartoscKrolikIWilk.Text = WartoscKrólikIWilk(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKrolikow).ToString();
            this.wartoscDwieOwce.Text = WartoscDwieOwce(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec).ToString();
            this.wartoscOwcaISwinia.Text = WartoscOwcaISwinia(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec,sSwin).ToString();
            this.wartoscOwcaIKrowa.Text = WartoscOwcaIKrowa(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec, sKrow).ToString();
            this.wartoscOwcaIKon.Text = WartoscOwcaIKon(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec, sKoni).ToString();
            this.wartoscOwcaILis.Text = WartoscOwcaILis(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec).ToString();
            this.wartoscOwcaIWilk.Text = WartoscOwcaIWilk(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec).ToString();
            this.wartoscDwieSwinie.Text = WartoscDwieSwinie(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies,sSwin).ToString();
            this.wartoscSwiniaIKrowa.Text = WartoscSwiniaIKrowa(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sSwin, sKrow).ToString();
            this.wartoscSwiniaIKon.Text = WartoscSwiniaIKon(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sSwin, sKoni).ToString();
            this.wartoscSwiniaILis.Text = WartoscSwiniaILis(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sSwin).ToString();
            this.wartoscSwiniaIWilk.Text = WartoscSwiniaIWilk(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sSwin).ToString();
            this.wartoscKrowaIKon.Text = WartoscKrowaIKon(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKrow, sKoni).ToString();
            this.wartoscKrowaIWilk.Text = WartoscKrowaIWilk(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies,sKrow).ToString();
            this.wartoscKonILis.Text = WartoscKonILis(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKoni).ToString();
            this.wartoscWilkILis.Text = WartoscWilkILis(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies).ToString();
            this.wartoscStada.Text = WartoscStada(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies).ToString();
            this.Wynik.Text = (WartoscDwaKroliki(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKrolikow) +
            WartoscKrólikIOwca(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec, sKrolikow) +
            WartoscKrólikISwinia(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sSwin, sKrolikow) +
            WartoscKrólikIKrowa(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKrow, sKrolikow) +
            WartoscKrólikIKon(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKoni, sKrolikow) +
            WartoscKrólikILis(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKrolikow) +
            WartoscKrólikIWilk(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKrolikow) +
            WartoscDwieOwce(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec)+
            WartoscOwcaISwinia(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec, sSwin) +
            WartoscOwcaIKrowa(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec, sKrow) +
            WartoscOwcaIKon(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec, sKoni) +
            WartoscOwcaILis(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec) +
            WartoscOwcaIWilk(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sOwiec) +
            WartoscDwieSwinie(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sSwin) +
            WartoscSwiniaIKrowa(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sSwin, sKrow) +
            WartoscSwiniaIKon(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sSwin, sKoni) +
            WartoscSwiniaILis(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sSwin) +
            WartoscSwiniaIWilk(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sSwin) +
            WartoscKrowaIKon(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKrow, sKoni) +
            WartoscKrowaIWilk(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKrow) +
            WartoscKonILis(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies, sKoni) +
            WartoscWilkILis(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies)).ToString();
            // MessageBox.Show(LiczZeWzoru(lKrolikow, lOwiec, lSwin, lKrow, lKoni, mPies, dPies).ToString());
        }

        public double LiczZeWzoru(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double krolikiStadoGlowne, double owceStadoGlowne, double swinieStadoGlowne, double krowyStadoGlowne, double konieStadoGlowne)
        {
            //double krolikiowca = sKrolikIOwca * WartoscKrolikIOwca(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double krolikiswinia = sKrolikISwinia * WartoscKrolikISwinia(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double krolikikrowa = sKrolikIKrowa * WartoscKrolikIKrowa(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double krolikikon = sKrolikIKon * WartoscKrolikIKon(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double krolikilis = sKrolikILis * WartoscKrolikILis(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double krolikiwilk = sKrolikIWilk * WartoscKrolikIWilk(kroliki, owce, swinie, krowy, konie, mPies, dPies);

            //double owcaiowca = sOwcaIOwca * WartoscDwieOwce(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double owcaiswinia = sOwcaISwinia * WartoscOwcaISwinia(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double owcaikrowa = sOwcaIKrowa * WartoscOwcaIKrowa(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double owcaikon = sOwcaIKon * WartoscOwcaIKon(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double owcailis = sOwcaILis * WartoscOwcaILis(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double owcaiwilk = sOwcaIWilk * WartoscOwcaIWilk(kroliki, owce, swinie, krowy, konie, mPies, dPies);

            //double swiniaiswinia = sSwiniaISwinia * WartoscDwieSwinie(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double swiniaikrowa = sSwiniaIKrowa * WartoscSwiniaIKrowa(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double swiniaikon = sSwiniaIKon * WartoscSwiniaIKon(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double swiniailis = sSwiniaILis * WartoscSwiniaILis(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double swiniaiwilk = sSwiniaIWilk * WartoscSwiniaIWilk(kroliki, owce, swinie, krowy, konie, mPies, dPies);

            //double krowaikon = sKrowaIKon * WartoscKrowaIKon(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double krowaiwilk = sKrowaIWilk * WartoscKrowaIWilk(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double konilis = sKonILis * WartoscKonILis(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            //double wilkilis = sWilkILis * WartoscWilkILis(kroliki, owce, swinie, krowy, konie, mPies, dPies);

            //double odpowiedz = sKrolikIKrolik * WartoscDwaKroliki(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sKrolikIOwca * WartoscKrolikIOwca(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sKrolikISwinia * WartoscKrolikISwinia(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sKrolikIKrowa * WartoscKrolikIKrowa(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sKrolikIKon * WartoscKrolikIKon(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sKrolikILis * WartoscKrolikILis(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sKrolikIWilk * WartoscKrolikIWilk(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sOwcaIOwca * WartoscDwieOwce(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sOwcaISwinia * WartoscOwcaISwinia(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sOwcaIKrowa * WartoscOwcaIKrowa(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sOwcaIKon * WartoscOwcaIKon(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sOwcaILis * WartoscOwcaILis(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sOwcaIWilk * WartoscOwcaIWilk(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sSwiniaISwinia * WartoscDwieSwinie(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sSwiniaIKrowa * WartoscSwiniaIKrowa(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sSwiniaIKon * WartoscSwiniaIKon(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sSwiniaILis * WartoscSwiniaILis(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sSwiniaIWilk * WartoscSwiniaIWilk(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sKrowaIKon * WartoscKrowaIKon(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sKrowaIWilk * WartoscKrowaIWilk(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sKonILis * WartoscKonILis(kroliki, owce, swinie, krowy, konie, mPies, dPies)
            //    + sWilkILis * WartoscWilkILis(kroliki, owce, swinie, krowy, konie, mPies, dPies);
            var odpowiedz = 2;
            return odpowiedz;
        }
        static public double WartoscStada(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies)
        {
            return kroliki + owce * 6 + swinie * 12 + krowy * 36 + konie * 72 + mPies * 6 + dPies * 36;
        }
        static public double WartoscDwaKroliki(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double krolikiStadoGlowne)
        {
            
            if (((int)kroliki / 2 + 1) <= krolikiStadoGlowne)
            {
                int pomoc = Convert.ToInt32(kroliki) / 2 + 1;
                double pomoc2 = Convert.ToDouble(pomoc);
                double wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                double wynik = (wartoscPoZdarzeniu * 36) / 144;

                return wynik;
            }
            else
            {
                double wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, dPies) + krolikiStadoGlowne;
                double wynik = (wartoscPoZdarzeniu * 36) / 144;
                return wynik;
            }

        }
        static public double WartoscDwieOwce(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double owceStadoGlowne)
        {

            if ((((int)owce) / 2 + 1) <= owceStadoGlowne)
            {
                int pomoc = ((Convert.ToInt32(owce) / 2) * 6) + 6;
                double pomoc2 = Convert.ToDouble(pomoc);
                double wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                double wynik = (wartoscPoZdarzeniu * 6) / 144;
                return wynik;
            }
            else
            {
                double wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, dPies) + owceStadoGlowne * 6;
                double wynik = (wartoscPoZdarzeniu * 6) / 144;
                return wynik;
            }

        }
        static public double WartoscDwieSwinie(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double swinieStadoGlowne)
        {

            if ((((int)swinie) / 2 + 1) <= swinieStadoGlowne)
            {
                int pomoc = ((Convert.ToInt32(swinie) / 2) * 12) + 12;
                double pomoc2 = Convert.ToDouble(pomoc);
                double wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                double wynik = (wartoscPoZdarzeniu * 2) / 144;
                return wynik;
            }
            else
            {
                double wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, dPies) + (swinieStadoGlowne * 12);
                double wynik = (wartoscPoZdarzeniu * 2) / 144;
                return wynik;
            }

        }
        static public double WartoscKrólikIOwca(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double owceStadoGlowne, double krolikiStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (owce % 2 == 0)
            {
                if ((((int)owce) / 2) <= owceStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(owce) / 2) * 6);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 30) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + owceStadoGlowne * 6;
                    wynik += (wartoscPoZdarzeniu * 30) / 144;
                }
            }
            else
            {
                if ((((int)owce) / 2 + 1) <= owceStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(owce) / 2) * 6) + 6;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 30) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + owceStadoGlowne * 6;
                    wynik += (wartoscPoZdarzeniu * 30) / 144;
                }
            }
            ////
            if (kroliki % 2 == 0)
            {
                if ((((int)kroliki) / 2) <= krolikiStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(kroliki) / 2) * 1);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 30) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + krolikiStadoGlowne;
                    wynik += (wartoscPoZdarzeniu * 30) / 144;
                }
            }
            else
            {
                if ((((int)kroliki) / 2 + 1) <= krolikiStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(kroliki) / 2)) + 1;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 30) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + krolikiStadoGlowne;
                    wynik += (wartoscPoZdarzeniu * 30) / 144;
                }
            }
            return wynik;
        }
        static public double WartoscKrólikISwinia(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double swinieStadoGlowne, double krolikiStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (swinie % 2 == 0)
            {
                if ((((int)swinie) / 2) <= swinieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(swinie) / 2) * 12);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 18) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + swinieStadoGlowne * 12;
                    wynik += (wartoscPoZdarzeniu * 18) / 144;
                }
            }
            else
            {
                if ((((int)swinie) / 2 + 1) <= swinieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(swinie) / 2) * 12) + 12;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 18) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + swinieStadoGlowne * 12;
                    wynik += (wartoscPoZdarzeniu * 18) / 144;
                }
            }
            ////
            if (kroliki % 2 == 0)
            {
                if ((((int)kroliki) / 2) <= krolikiStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(kroliki) / 2) * 1);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 18) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + krolikiStadoGlowne;
                    wynik += (wartoscPoZdarzeniu * 18) / 144;
                }
            }
            else
            {
                if ((((int)kroliki) / 2 + 1) <= krolikiStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(kroliki) / 2)) + 1;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 18) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + krolikiStadoGlowne;
                    wynik += (wartoscPoZdarzeniu * 18) / 144;
                }
            }
            return wynik;
        }
        static public double WartoscKrólikIKrowa(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double krowyStadoGlowne, double krolikiStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (krowy % 2 == 0)
            {
                if ((((int)krowy) / 2) <= krowyStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(krowy) / 2) * 36);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + krowyStadoGlowne * 36;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
            }
            else
            {
                if ((((int)krowy) / 2 + 1) <= krowyStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(krowy) / 2) * 36) + 36;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + krowyStadoGlowne * 36;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
            }
            ////
            if (kroliki % 2 == 0)
            {
                if ((((int)kroliki) / 2) <= krolikiStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(kroliki) / 2) * 1);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + krolikiStadoGlowne;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
            }
            else
            {
                if ((((int)kroliki) / 2 + 1) <= krolikiStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(kroliki) / 2)) + 1;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + krolikiStadoGlowne;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
            }
            return wynik;
        }
        static public double WartoscKrólikIKon(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double konieStadoGlowne, double krolikiStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (konie % 2 == 0)
            {
                if ((((int)konie) / 2) <= konieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(konie) / 2) * 72);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + konieStadoGlowne * 72;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
            }
            else
            {
                if ((((int)konie) / 2 + 1) <= konieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(konie) / 2) * 72) + 72;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + konieStadoGlowne * 72;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
            }
            ////
            if (kroliki % 2 == 0)
            {
                if ((((int)kroliki) / 2) <= krolikiStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(kroliki) / 2) * 1);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + krolikiStadoGlowne;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
            }
            else
            {
                if ((((int)kroliki) / 2 + 1) <= krolikiStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(kroliki) / 2)) + 1;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, 0, 0, 0) + krolikiStadoGlowne;
                    wynik += (wartoscPoZdarzeniu * 6) / 144;
                }
            }
            return wynik;
        }
        static public double WartoscKrólikILis(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double krolikiStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (mPies >= 1)
            {
                if (kroliki % 2 == 0)
                {
                    if ((((int)kroliki) / 2) <= krolikiStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(kroliki) / 2) * 1);
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + krolikiStadoGlowne;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                }
                else
                {
                    if ((((int)kroliki) / 2 + 1) <= krolikiStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(kroliki) / 2)) + 1;
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + krolikiStadoGlowne;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                }
            }
            else
            {
                if (kroliki >= 1)
                {
                    wynik = (WartoscStada(1, owce, swinie, krowy, konie, mPies, dPies) * 6) / 144;
                }
                else
                {
                    wynik = (WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) * 6) / 144;
                }

            }

            return wynik;
        }
        static public double WartoscKrólikIWilk(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double krolikiStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (dPies >= 1)
            {
                if (kroliki % 2 == 0)
                {
                    if ((((int)kroliki) / 2) <= krolikiStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(kroliki) / 2) * 1);
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + krolikiStadoGlowne;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                }
                else
                {
                    if ((((int)kroliki) / 2 + 1) <= krolikiStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(kroliki) / 2)) + 1;
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + krolikiStadoGlowne;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                }
            }
            else
            {
                if (kroliki % 2 == 0)
                {
                    if ((((int)kroliki) / 2) <= krolikiStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(kroliki) / 2) * 1);
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, konie, mPies, 0) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, konie, mPies, 0) + krolikiStadoGlowne;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                }
                else
                {
                    if ((((int)kroliki) / 2 + 1) <= krolikiStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(kroliki) / 2)) + 1;
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, konie, mPies, 0) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, konie, mPies, 0) + krolikiStadoGlowne;
                        wynik += (wartoscPoZdarzeniu * 6) / 144;
                    }
                }
            }

            return wynik;
        }
        static public double WartoscOwcaISwinia(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double owceStadoGlowne, double swinieStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (owce % 2 == 0)
            {
                if ((((int)owce) / 2) <= owceStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(owce) / 2) * 6);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, 0, krowy, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 8) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, 0, krowy, konie, mPies, dPies) + owceStadoGlowne * 6;
                    wynik += (wartoscPoZdarzeniu * 8) / 144;
                }
            }
            else
            {
                if ((((int)owce) / 2 + 1) <= owceStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(owce) / 2) * 6) + 6;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, 0, krowy, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 8) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, 0, krowy, konie, mPies, dPies) + owceStadoGlowne * 6;
                    wynik += (wartoscPoZdarzeniu * 8) / 144;
                }
            }
            ////
            if (swinie % 2 == 0)
            {
                if ((((int)swinie) / 2) <= swinieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(swinie) / 2) * 12);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, swinie, 0, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 8) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, swinie, 0, 0, 0, 0) + (swinieStadoGlowne * 12);
                    wynik += (wartoscPoZdarzeniu * 8) / 144;
                }
            }
            else
            {
                if ((((int)swinie) / 2 + 1) <= swinieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(swinie) / 2) * 12) + 12;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, swinie, 0, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 8) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, swinie, 0, 0, 0, 0) + (swinieStadoGlowne * 12);
                    wynik += (wartoscPoZdarzeniu * 8) / 144;
                }
            }
            return wynik;
        }
        static public double WartoscOwcaIKrowa(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double owceStadoGlowne, double krowyStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (owce % 2 == 0)
            {
                if ((((int)owce) / 2) <= owceStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(owce) / 2) * 6);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, 0, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, 0, konie, mPies, dPies) + owceStadoGlowne * 6;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
            }
            else
            {
                if ((((int)owce) / 2 + 1) <= owceStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(owce) / 2) * 6) + 6;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, 0, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, 0, konie, mPies, dPies) + owceStadoGlowne * 6;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
            }
            ////
            if (krowy % 2 == 0)
            {
                if ((((int)krowy) / 2) <= krowyStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(krowy) / 2) * 36);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, krowy, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, krowy, 0, 0, 0) + krowyStadoGlowne * 36;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
            }
            else
            {
                if ((((int)krowy) / 2 + 1) <= krowyStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(krowy) / 2) * 36) + 36;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, krowy, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, krowy, 0, 0, 0) + krowyStadoGlowne * 36;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
            }
            return wynik;
        }
        static public double WartoscOwcaIKon(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double owceStadoGlowne, double konieStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (owce % 2 == 0)
            {
                if ((((int)owce) / 2) <= owceStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(owce) / 2) * 6);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 3) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + owceStadoGlowne * 6;
                    wynik += (wartoscPoZdarzeniu * 3) / 144;
                }
            }
            else
            {
                if ((((int)owce) / 2 + 1) <= owceStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(owce) / 2) * 6) + 6;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 3) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + owceStadoGlowne * 6;
                    wynik += (wartoscPoZdarzeniu * 3) / 144;
                }
            }
            ////
            if (konie % 2 == 0)
            {
                if ((((int)konie) / 2) <= konieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(konie) / 2) * 72);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 3) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + konieStadoGlowne * 72;
                    wynik += (wartoscPoZdarzeniu * 3) / 144;
                }
            }
            else
            {
                if ((((int)konie) / 2 + 1) <= konieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(konie) / 2) * 72) + 72;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 3) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + konieStadoGlowne * 72;
                    wynik += (wartoscPoZdarzeniu * 3) / 144;
                }
            }
            return wynik;
        }
        static public double WartoscOwcaILis(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double owceStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (mPies >= 1)
            {
                if (owce % 2 == 0)
                {
                    if ((((int)owce) / 2) <= owceStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(owce) / 2) * 6);
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 3) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + owceStadoGlowne * 6;
                        wynik += (wartoscPoZdarzeniu * 3) / 144;
                    }
                }
                else
                {
                    if ((((int)owce) / 2 + 1) <= owceStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(owce) / 2) * 6) + 6;
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 3) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + owceStadoGlowne * 6;
                        wynik += (wartoscPoZdarzeniu * 3) / 144;
                    }
                }
            }
            else
            {
                if (kroliki >= 1)
                {
                    if (owce % 2 == 0)
                    {
                        if ((((int)owce) / 2) <= owceStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(owce) / 2) * 6);
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 3) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, 0, dPies) + owceStadoGlowne * 6;
                            wynik += (wartoscPoZdarzeniu * 3) / 144;
                        }
                    }
                    else
                    {
                        if ((((int)owce) / 2 + 1) <= owceStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(owce) / 2) * 6) + 6;
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 3) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, 0, dPies) + owceStadoGlowne * 6;
                            wynik += (wartoscPoZdarzeniu * 3) / 144;
                        }
                    }
                }
                else
                {
                    if (owce % 2 == 0)
                    {
                        if ((((int)owce) / 2) <= owceStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(owce) / 2) * 6);
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 3) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, 0, dPies) + owceStadoGlowne * 6;
                            wynik += (wartoscPoZdarzeniu * 3) / 144;
                        }
                    }
                    else
                    {
                        if ((((int)owce) / 2 + 1) <= owceStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(owce) / 2) * 6) + 6;
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 3) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, 0, dPies) + owceStadoGlowne * 6;
                            wynik += (wartoscPoZdarzeniu * 3) / 144;
                        }
                    }
                }

            }

            return wynik;
        }
        static public double WartoscOwcaIWilk(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double owceStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (dPies >= 1)
            {
                if (owce % 2 == 0)
                {
                    if ((((int)owce) / 2) <= owceStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(owce) / 2) * 6);
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 2) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + owceStadoGlowne * 6;
                        wynik += (wartoscPoZdarzeniu * 2) / 144;
                    }
                }
                else
                {
                    if ((((int)owce) / 2 + 1) <= owceStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(owce) / 2) * 6) + 6;
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 2) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + owceStadoGlowne * 6;
                        wynik += (wartoscPoZdarzeniu * 2) / 144;
                    }
                }
            }
            else
            {

                wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, konie, mPies, dPies);
                wynik += (wartoscPoZdarzeniu * 2) / 144;

            }

            return wynik;
        }
        static public double WartoscSwiniaIKrowa(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double swinieStadoGlowne, double krowyStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (swinie % 2 == 0)
            {
                if ((((int)swinie) / 2) <= swinieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(swinie) / 2) * 12);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, 0, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, 0, konie, mPies, dPies) + swinieStadoGlowne * 12;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
            }
            else
            {
                if ((((int)swinie) / 2 + 1) <= swinieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(swinie) / 2) * 12) + 12;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, 0, konie, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, 0, konie, mPies, dPies) + swinieStadoGlowne * 12;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
            }
            if (krowy % 2 == 0)
            {
                if ((((int)krowy) / 2) <= krowyStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(krowy) / 2) * 36);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, krowy, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, krowy, 0, 0, 0) + krowyStadoGlowne * 36;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
            }
            else
            {
                if ((((int)krowy) / 2 + 1) <= krowyStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(krowy) / 2) * 36) + 36;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, krowy, 0, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, krowy, 0, 0, 0) + krowyStadoGlowne * 36;
                    wynik += (wartoscPoZdarzeniu * 2) / 144;
                }
            }
            return wynik;
        }
        static public double WartoscSwiniaIKon(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double swinieStadoGlowne, double konieStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (swinie % 2 == 0)
            {
                if ((((int)swinie) / 2) <= swinieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(swinie) / 2) * 12);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + swinieStadoGlowne * 12;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
            }
            else
            {
                if ((((int)swinie) / 2 + 1) <= swinieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(swinie) / 2) * 12) + 12;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + swinieStadoGlowne * 12;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
            }
            if (konie % 2 == 0)
            {
                if ((((int)konie) / 2) <= konieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(konie) / 2) * 72);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + konieStadoGlowne * 72;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
            }
            else
            {
                if ((((int)konie) / 2 + 1) <= konieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(konie) / 2) * 72) + 72;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + konieStadoGlowne * 72;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
            }
            return wynik;
        }

        static public double WartoscSwiniaILis(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double swinieStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (mPies >= 1)
            {
                if (swinie % 2 == 0)
                {
                    if ((((int)swinie) / 2) <= swinieStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(swinie) / 2) * 12);
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + swinieStadoGlowne * 12;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                }
                else
                {
                    if ((((int)swinie) / 2 + 1) <= swinieStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(swinie) / 2) * 12) + 12;
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + swinieStadoGlowne * 12;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                }
            }
            else
            {
                if (kroliki >= 1)
                {
                    if (swinie % 2 == 0)
                    {
                        if ((((int)swinie) / 2) <= swinieStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(swinie) / 2) * 12);
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, mPies, dPies) + swinieStadoGlowne * 12;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                    }
                    else
                    {
                        if ((((int)swinie) / 2 + 1) <= swinieStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(swinie) / 2) * 12) + 12;
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, mPies, dPies) + swinieStadoGlowne * 12;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                    }
                }
                else
                {
                    if (swinie % 2 == 0)
                    {
                        if ((((int)swinie) / 2) <= swinieStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(swinie) / 2) * 12);
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + swinieStadoGlowne * 12;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                    }
                    else
                    {
                        if ((((int)swinie) / 2 + 1) <= swinieStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(swinie) / 2) * 12) + 12;
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + swinieStadoGlowne * 12;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                    }
                }

            }

            return wynik;
        }
        static public double WartoscSwiniaIWilk(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double swinieStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (dPies >= 1)
            {
                if (swinie % 2 == 0)
                {
                    if ((((int)swinie) / 2) <= swinieStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(swinie) / 2) * 12);
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 2) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + swinieStadoGlowne * 12;
                        wynik += (wartoscPoZdarzeniu * 2) / 144;
                    }
                }
                else
                {
                    if ((((int)swinie) / 2 + 1) <= swinieStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(swinie) / 2) * 12) + 12;
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 2) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + swinieStadoGlowne * 12;
                        wynik += (wartoscPoZdarzeniu * 2) / 144;
                    }
                }
            }
            else
            {
                wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, konie, mPies, dPies);
                wynik += (wartoscPoZdarzeniu * 2) / 144;
            }

            return wynik;
        }
        static public double WartoscKrowaIKon(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double krowyStadoGlowne, double konieStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (krowy % 2 == 0)
            {
                if ((((int)krowy) / 2) <= krowyStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(krowy) / 2) * 36);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + krowyStadoGlowne * 36;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
            }
            else
            {
                if ((((int)krowy) / 2 + 1) <= krowyStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(krowy) / 2) * 36) + 36;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, 0, mPies, dPies) + krowyStadoGlowne * 36;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
            }
            ////
            if (konie % 2 == 0)
            {
                if ((((int)konie) / 2) <= konieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(konie) / 2) * 72);
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + konieStadoGlowne * 72;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
            }
            else
            {
                if ((((int)konie) / 2 + 1) <= konieStadoGlowne)
                {
                    int pomoc = ((Convert.ToInt32(konie) / 2) * 72) + 72;
                    pomoc2 = Convert.ToDouble(pomoc);
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + pomoc2;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
                else
                {
                    wartoscPoZdarzeniu = WartoscStada(0, 0, 0, 0, konie, 0, 0) + konieStadoGlowne * 72;
                    wynik += (wartoscPoZdarzeniu * 1) / 144;
                }
            }
            return wynik;
        }
        static public double WartoscKrowaIWilk(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double krowyStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (dPies >= 1)
            {
                if (krowy % 2 == 0)
                {
                    if ((((int)krowy) / 2) <= krowyStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(krowy) / 2) * 36);
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + krowyStadoGlowne * 36;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                }
                else
                {
                    if ((((int)krowy) / 2 + 1) <= krowyStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(krowy) / 2) * 36) + 36;
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, mPies, 0) + krowyStadoGlowne * 36;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                }
            }
            else
            {
                wartoscPoZdarzeniu = WartoscStada(kroliki, 0, 0, 0, konie, mPies, dPies);
                wynik += (wartoscPoZdarzeniu * 1) / 144;
            }
            ////

            return wynik;
        }
        static public double WartoscKonILis(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies, double konieStadoGlowne)
        {
            double wynik = 0;
            double wartoscPoZdarzeniu = 0;
            double pomoc2 = 0;
            if (mPies >= 1)
            {
                if (konie % 2 == 0)
                {
                    if ((((int)konie) / 2) <= konieStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(konie) / 2) * 72);
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + konieStadoGlowne * 72;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                }
                else
                {
                    if ((((int)konie) / 2 + 1) <= konieStadoGlowne)
                    {
                        int pomoc = ((Convert.ToInt32(konie) / 2) * 72) + 72;
                        pomoc2 = Convert.ToDouble(pomoc);
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + pomoc2;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                    else
                    {
                        wartoscPoZdarzeniu = WartoscStada(kroliki, owce, swinie, krowy, konie, 0, dPies) + konieStadoGlowne * 72;
                        wynik += (wartoscPoZdarzeniu * 1) / 144;
                    }
                }
            }
            else
            {
                if (kroliki >= 1)
                {
                    if (konie % 2 == 0)
                    {
                        if ((((int)konie) / 2) <= konieStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(konie) / 2) * 72);
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, mPies, dPies) + konieStadoGlowne * 72;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                    }
                    else
                    {
                        if ((((int)konie) / 2 + 1) <= konieStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(konie) / 2) * 72) + 72;
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(1, owce, swinie, krowy, konie, mPies, dPies) + konieStadoGlowne * 72;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                    }
                }
                else
                {
                    if (konie % 2 == 0)
                    {
                        if ((((int)konie) / 2) <= konieStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(konie) / 2) * 72);
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + konieStadoGlowne * 72;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                    }
                    else
                    {
                        if ((((int)konie) / 2 + 1) <= konieStadoGlowne)
                        {
                            int pomoc = ((Convert.ToInt32(konie) / 2) * 72) + 72;
                            pomoc2 = Convert.ToDouble(pomoc);
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + pomoc2;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                        else
                        {
                            wartoscPoZdarzeniu = WartoscStada(0, owce, swinie, krowy, konie, mPies, dPies) + konieStadoGlowne * 72;
                            wynik += (wartoscPoZdarzeniu * 1) / 144;
                        }
                    }
                }

            }

            return wynik;
        }
        static public double WartoscWilkILis(double kroliki, double owce, double swinie, double krowy, double konie, double mPies, double dPies)
        {
            if (mPies >= 1)
            {
                if (dPies >= 1)
                {
                    return WartoscStada(kroliki, owce, swinie, krowy, konie, 0, 0) / 144;
                }
                else
                {
                    return WartoscStada(kroliki, 0, 0, 0, konie, 0, 0) / 144;
                }
            }
            else
            {
                if (kroliki >= 1)
                {
                    if (dPies >= 1)
                    {
                        return WartoscStada(1, owce, swinie, krowy, konie, 0, 0) / 144;
                    }
                    else
                    {
                        return WartoscStada(1, 0, 0, 0, konie, 0, 0) / 144;
                    }
                }
                else
                {
                    if (dPies >= 1)
                    {
                        return WartoscStada(0, owce, swinie, krowy, konie, 0, 0) / 144;
                    }
                    else
                    {
                        return WartoscStada(0, 0, 0, 0, konie, 0, 0) / 144;
                    }
                }
            }
        }

    }
}
