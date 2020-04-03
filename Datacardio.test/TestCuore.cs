using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Datacardio.test
{
    [TestClass]
    public class TestCuore
    {
        [TestMethod]
        public void Cardio1() //punto 1 calcolo bpm massimo
        {
            int bpm = 197;
            double frequenza = CardioLibrary.calcolicuore.Cardio(23);
            Assert.AreEqual(bpm, frequenza);

        }
        [TestMethod]
        public void Cardio2() //punto 1 calcolo bpm massimo
        {

            int bpm = 149;
            double frequenza = CardioLibrary.calcolicuore.Cardio(71);
            Assert.AreEqual(bpm, frequenza);
        }
        [TestMethod]
        public void Cardio3() //punto 1 calcolo bpm massimo
        {
            int bpm = 180;
            double frequenza = CardioLibrary.calcolicuore.Cardio(40);
            Assert.AreEqual(bpm, frequenza);
        }
        [TestMethod]
        public void Cardio4() //punto 1 calcolo bpm massimo
        {
            int bpm = 185;
            double frequenza = CardioLibrary.calcolicuore.Cardio(35);
            Assert.AreEqual(bpm, frequenza);

        }
        [TestMethod]
        public void Cardio5() //punto 1 calcolo bpm massimo
        {
            int bpm = 170;
            double frequenza = CardioLibrary.calcolicuore.Cardio(50);
            Assert.AreEqual(bpm, frequenza);
        }
        [DataTestMethod] //punto 1 calcolo bpm massimo effettuato con il datarow
        [DataRow(23, 197)]
        [DataRow(71, 149)]
        [DataRow(40, 180)]
        [DataRow(35, 185)]
        [DataRow(50, 170)]
        public void CardioData(int anni, int bpm)
        {

            double frequenza = CardioLibrary.calcolicuore.Cardio(anni);
            Assert.AreEqual(bpm, frequenza);


        }
        [TestMethod]
        public void FrequenzaMinimaGym1() //punto 1.2 calcolo bpm efficaci per un allenamento
        {
            int minima = 93;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(134);
            Assert.AreEqual(minima, frequenza);
        }

        [TestMethod]
        public void FrequenzaMinimaGym2() //punto 1.2 calcolo bpm efficaci per un allenamento
        {
            int minima = 140;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(200);
            Assert.AreEqual(minima, frequenza);

        }
        [TestMethod]
        public void FrequenzaMinimaGym3() //punto 1.2 calcolo bpm efficaci per un allenamento
        {
            int minima = 117;
            double frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(168);
            Assert.AreEqual(minima, frequenza);

        }
        [TestMethod]
        public void FrequenzaMinimaGym4() //punto 1.2 calcolo bpm efficaci per un allenamento
        {
            int minima = 133;
            double frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(190);
            Assert.AreEqual(minima, frequenza);

        }
        [TestMethod]
        public void FrequenzaMinimaGym5() //punto 1.2 calcolo bpm efficaci per un allenamento
        {
            int minima = 142;
            double frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(204);
            Assert.AreEqual(minima, frequenza);

        }
        [DataTestMethod] //punto 1.2 calcolo bpm efficaci minimi per un allenamento,con datarow
        [DataRow(204, 142)]
        [DataRow(190, 133)]
        [DataRow(168, 117)]
        [DataRow(200, 140)]
        [DataRow(134, 93)]
        public void FrequenzaMinimaGymData(int bpm, int aspettata)
        {

            double frequenzaMinGym = CardioLibrary.calcolicuore.frequenzaCardiomin(bpm);
            Assert.AreEqual(aspettata, frequenzaMinGym);
           

        }

        [TestMethod]
        public void FrequenzaMassimaGym1() //punto 1.2 calcolo bpm efficaci massimi per un allenamento
        {
            int massima = 129;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomax(144);
            Assert.AreEqual(massima, frequenza);
        }
        [TestMethod]
        public void FrequenzaMassimaGym2()
        {
            int massima = 150;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomax(167);
            Assert.AreEqual(massima, frequenza);
        }
        [TestMethod]
        public void FrequenzaMassimaGym3()
        {
            int massima = 111;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomax(124);
            Assert.AreEqual(massima, frequenza);
        }
        [TestMethod]
        public void FrequenzaMassimaGym4()
        {
            int massima = 189;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomax(210);
            Assert.AreEqual(massima, frequenza);
        }
        [TestMethod]
        public void FrequenzaMassimaGym5()
        {
            int massima = 93;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomax(104);
            Assert.AreEqual(massima, frequenza);
        }
        [TestMethod] //punto 1.2 calcolo bpm efficaci massimi per un allenamento,con datarow
        [DataRow(144, 129)]
        [DataRow(167, 150)]
        [DataRow(124, 111)]
        [DataRow(210, 189)]
        [DataRow(104, 93)]
        public void FrequenzaMassimaGymData(int bpm, int massima)
        {

            int frequenzaMaxGym = CardioLibrary.calcolicuore.frequenzaCardiomax(bpm);
            Assert.AreEqual(massima, frequenzaMaxGym);

           
        }



        [TestMethod] //punto 1.2 calcolo bpm efficaci per un allenamento
        public void FrequenzaCardio1()
        {
            int frequenzaGinnastica = 157;
            double bpm = CardioLibrary.calcolicuore.frequenzaCardioGym(197);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio2()
        {
            int frequenzaGinnastica = 119;
            double bpm = CardioLibrary.calcolicuore.frequenzaCardioGym(149);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio3()
        {
            int frequenzaGinnastica = 144;
            double bpm = CardioLibrary.calcolicuore.frequenzaCardioGym(180);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio4()
        {
            int frequenzaGinnastica = 148;
            double bpm = CardioLibrary.calcolicuore.frequenzaCardioGym(186);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio5()
        {
            int frequenzaGinnastica = 136;
            double bpm = CardioLibrary.calcolicuore.frequenzaCardioGym(170);
            Assert.AreEqual(frequenzaGinnastica, bpm);
        }

        [DataTestMethod] //punto 1.2 calcolo bpm efficaci per un allenamento,con datarow
        [DataRow(197, 157)]
        [DataRow(149, 119)]
        [DataRow(180, 144)]
        [DataRow(186, 148)]
        [DataRow(170, 136)]
        public void FrequenzaCardioData(int bpm, int frequenzaGinnastica)
        {

            double bpmEfficiente = CardioLibrary.calcolicuore.frequenzaCardioGym(bpm);
            Assert.AreEqual(frequenzaGinnastica, bpmEfficiente);


          
        }
        [TestMethod] //punto2
        public void BpmMinututo1()
        {
            string risultato = "normale";
            string battito = CardioLibrary.calcolicuore.Battito(100);
            Assert.AreEqual(risultato, battito);

        }
        [TestMethod]
        public void BpmMinututo2()
        {
            string risultato = "tachicardico";
            string battito = CardioLibrary.calcolicuore.Battito(110);
            Assert.AreEqual(risultato, battito);

        }
        [TestMethod]
        public void BpmMinututo3()
        {
            string risultato = "normale";
            string battito = CardioLibrary.calcolicuore.Battito(100);
            Assert.AreEqual(risultato, battito);

        }
        [TestMethod]
        public void BpmMinututo4()
        {
            string risultato = "bradicardico";
            string battito = CardioLibrary.calcolicuore.Battito(50);
            Assert.AreEqual(risultato, battito);

        }
        [TestMethod]
        public void BpmMinututo5()
        {
            string risultato = "normale";
            string battito = CardioLibrary.calcolicuore.Battito(100);
            Assert.AreEqual(risultato, battito);

        }
        [DataTestMethod] //punto2
        [DataRow(160, "tachicardico")]
        [DataRow(68, "normale")]
        [DataRow(100, "normale")]
        [DataRow(102, "tachicardico")]
        public void BpmMinutiData(int battiti, string risultato)
        {

            string battito = CardioLibrary.calcolicuore.Battito(battiti);
            Assert.AreEqual(risultato, battito);


            


        }
        [TestMethod] //punto3 calcolo calorie uomo/donna
        public void CalorieUomini1()
        {
            double calorie = 1133.0114722753347;
            double frequenza = CardioLibrary.calcolicuore.ConsumoCalorieUomo(78, 98.5, 35, 160); //peso,frequenza,anni,allenamento;
            Assert.AreEqual(calorie, frequenza);

        }
        [TestMethod]
        public void CalorieDonna1()
        {
            double calorie = 805.1716061185465;
            double frequenza = CardioLibrary.calcolicuore.ConsumoCalorieDonna(68, 87.5, 45, 110);
            Assert.AreEqual(calorie, frequenza);

        }
        [TestMethod]
        public void CalorieUomini2()
        {
            double calorie = 1471.7065009560226;
            double frequenza = CardioLibrary.calcolicuore.ConsumoCalorieDonna(100, 86, 48, 180);
            Assert.AreEqual(calorie, frequenza);

        }
        [TestMethod]
        public void CalorieDonna2()
        {
            double calorie = 1600.1816443594646;
            double frequenza = CardioLibrary.calcolicuore.ConsumoCalorieDonna(55, 102.5, 15, 200);
            Assert.AreEqual(calorie, frequenza);


        }
        [DataTestMethod]
        [DataRow(78, 98.5, 35, 160, 1133.0114722753347)]
        [DataRow(68, 87.5, 45, 160, 868.655831739962)]
        [DataRow(100, 86, 48, 180, 1236.5148183556405)]
        [DataRow(55, 102.5, 15, 200, 1125.279636711281)]
        public void CalorieData(double peso, double bpm, double anni, double esercizio, double calorie)
        {

            double CalorieData = CardioLibrary.calcolicuore.ConsumoCalorieUomo(peso, bpm, anni, esercizio); //peso,frequenza,anni,allenamento;
            Assert.AreEqual(calorie, CalorieData);





        }

        [TestMethod] //spesa energetica corsa
        public void corsa1()
        {
            double risultato = 62.1;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_corsa(1, 69);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void corsa2()
        {
            double risultato = 160.704;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_corsa(2.88, 62);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void corsa3()
        {
            double risultato = 225;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_corsa(5, 50);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void corsa4()
        {
            double risultato = 17521.2;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_corsa(314, 62);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void corsa5()
        {
            double risultato = 252;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_corsa(3.5, 80);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [DataTestMethod] //spesa energetica corsa con datarow
        [DataRow(20, 67, 1206)]
        [DataRow(310, 45, 12555)]
        [DataRow(16, 88, 1267.2)]
        [DataRow(2, 70, 126)]
        [DataRow(4.5, 90, 364.5)]
        public void Spesa_enerigetica_CorsaData(double km, double kg, double aspettata)
        {

            double spesa_emnergeticaData = CardioLibrary.calcolicuore.spesa_energetica_corsa(km, kg);
            Assert.AreEqual(aspettata, spesa_emnergeticaData);
          


        }
        [TestMethod] //spesa energetica camminata
        public void camminata1()
        {
            double risultato = 164;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_camminata(4, 82);
            Assert.AreEqual(risultato, spesa_energetica);

        }

        public void camminata2()
        {
            double risultato = 90;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_camminata(2, 90);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void camminata3()
        {
            double risultato = 33.75;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_camminata(1.5, 45);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void camminata4()
        {
            double risultato = 240;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_camminata(8, 60);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void camminata5()
        {
            double risultato = 350;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_camminata(10, 70);
            Assert.AreEqual(risultato, spesa_energetica);


        }
        [DataTestMethod] //spesa energetica camminata con datarow
        [DataRow(20, 67, 670)]
        [DataRow(3, 45, 67.5)]
        [DataRow(6, 90, 270)]
        [DataRow(8, 70, 280)]
        [DataRow(9, 50, 225)]
        public void Spesa_enerigetica_CamminataData(double km, double kg, double aspettata)
        {

            double spesa_emnergeticaData = CardioLibrary.calcolicuore.spesa_energetica_camminata(km, kg);
            Assert.AreEqual(aspettata, spesa_emnergeticaData);
          
        }

        [TestMethod]
        public void media1()
        {
            int risultato = 61;
            int Media = CardioLibrary.calcolicuore.Media_bpm(40, 48, 53, 62, 45, 56, 48, 60, 62, 62, 68, 70, 72, 78, 80, 93, 70, 72, 69, 60, 45, 60, 50, 63);
            Assert.AreEqual(risultato, Media);
        }
        [TestMethod]
        public void media2()
        {
            int risultato = 64;
            int Media = CardioLibrary.calcolicuore.Media_bpm(42, 45, 45, 56, 55, 50, 69, 70, 75, 80, 78, 69, 68, 65, 66, 70, 72, 78, 69, 70, 72, 65, 58, 49);
            Assert.AreEqual(risultato, Media);
        }
        [TestMethod]
        public void media3()
        {
            int risultato = 68;
            int Media = CardioLibrary.calcolicuore.Media_bpm(40, 48, 53, 62, 65, 76, 78, 80, 72, 74, 88, 90, 92, 88, 80, 73, 70, 72, 69, 65, 55, 60, 50, 45);
            Assert.AreEqual(risultato, Media);
        }
        [TestMethod]
        public void media4()
        {
            int risultato = 62;
            int Media = CardioLibrary.calcolicuore.Media_bpm(40, 48, 53, 54, 55, 56, 68, 74, 72, 82, 68, 70, 72, 78, 60, 93, 70, 72, 69, 60, 45, 58, 50, 43);
            Assert.AreEqual(risultato, Media);
        }
        [TestMethod]
        public void media5()
        {
            int risultato = 64;
            int Media = CardioLibrary.calcolicuore.Media_bpm(46, 38, 58, 63, 48, 56, 48, 68, 62, 62, 65, 72, 74, 78, 80, 93, 90, 80, 75, 70, 65, 55, 50, 45);
            Assert.AreEqual(risultato, Media);
        }

        [DataTestMethod] //media bpm con datarow
        [DataRow(48, 46, 54, 56, 58, 60, 62, 64, 66, 68, 70, 75, 77, 69, 70, 72, 69, 68, 66, 67, 60, 58, 56, 54, 63)]
        [DataRow(48, 50, 52, 55, 60, 65, 62, 68, 69, 72, 77, 70, 74, 70, 68, 66, 60, 58, 55, 50, 48, 46, 44, 44, 59)]
        [DataRow(48, 52, 58, 64, 58, 70, 75, 78, 80, 82, 82, 80, 83, 84, 75, 79, 80, 81, 82, 64, 65, 60, 58, 57, 70)]
        [DataRow(46, 48, 49, 52, 54, 58, 56, 57, 60, 62, 64, 59, 60, 62, 64, 70, 72, 78, 72, 68, 66, 63, 60, 58, 60)]
        [DataRow(40, 42, 43, 44, 45, 48, 50, 52, 55, 58, 59, 62, 68, 70, 72, 70, 69, 68, 65, 60, 55, 53, 50, 49, 56)]
        public void Media_bpm(int bpm1, int bpm2, int bpm3, int bpm4, int bpm5, int bpm6, int bpm7, int bpm8, int bpm9, int bpm10, int bpm11, int bpm12, int bpm13, int bpm14, int bpm15, int bpm16, int bpm17, int bpm18, int bpm19, int bpm20, int bpm21, int bpm22, int bpm23, int bpm24, int aspettata)
        {

            int mediaData = CardioLibrary.calcolicuore.Media_bpm(bpm1, bpm2, bpm3, bpm4, bpm5, bpm6, bpm7, bpm8, bpm9, bpm10, bpm11, bpm12, bpm13, bpm14, bpm15, bpm16, bpm17, bpm18, bpm19, bpm20, bpm21, bpm22, bpm23, bpm24);
            Assert.AreEqual(aspettata, mediaData);
         
        }

        [TestMethod]
        public void riposo1()
        {
            int risultato = 49;
            int Media = CardioLibrary.calcolicuore.Riposo_bpm(46, 48, 45, 56, 50, 52, 47);
            Assert.AreEqual(risultato, Media);
        }
        [TestMethod]
        public void riposo2()
        {
            int risultato = 53;
            int Media = CardioLibrary.calcolicuore.Riposo_bpm(56, 58, 55, 56, 50, 52, 47);
            Assert.AreEqual(risultato, Media);
        }
        [TestMethod]
        public void riposo3()
        {
            int risultato = 45;
            int Media = CardioLibrary.calcolicuore.Riposo_bpm(46, 38, 45, 56, 40, 42, 53);
            Assert.AreEqual(risultato, Media);
        }
        [TestMethod]
        public void riposo4()
        {
            int risultato = 41;
            int Media = CardioLibrary.calcolicuore.Riposo_bpm(40, 38, 45, 46, 40, 41, 43);
            Assert.AreEqual(risultato, Media);
        }
        [TestMethod]
        public void riposo5()
        {
            int risultato = 47;
            int Media = CardioLibrary.calcolicuore.Riposo_bpm(44, 48, 45, 50, 46, 52, 47);
            Assert.AreEqual(risultato, Media);
        }
        [DataTestMethod]
        [DataRow(54, 56, 48, 48, 50, 51, 46, 50)]
        [DataRow(50, 46, 48, 53, 50, 55, 45, 49)]
        [DataRow(48, 36, 47, 58, 50, 51, 46, 48)]
        [DataRow(54, 47, 38, 48, 40, 41, 36, 43)]
        [DataRow(44, 37, 38, 48, 40, 41, 39, 41)]
        public void riposodta(int bpm1, int bpm2, int bpm3, int bpm4, int bpm5, int bpm6, int bpm7, int risposta_aspettata)
        {
            int MediaRiposoData = CardioLibrary.calcolicuore.Riposo_bpm(bpm1, bpm2, bpm3, bpm4, bpm5, bpm6, bpm7);
            Assert.AreEqual(risposta_aspettata, MediaRiposoData);
        
        }
        [TestMethod]
        public void Variabilità1()
        {
            double risultato = 3.06;
            double variabilità1 = CardioLibrary.calcolicuore.Variabilità_bpm(51);
            Assert.AreEqual(risultato, variabilità1);
        }
        [TestMethod]
        public void Variabilità2()
        {
            double risultato = 2.28;
            double variabilit2 = CardioLibrary.calcolicuore.Variabilità_bpm(38);
            Assert.AreEqual(risultato, variabilit2);
        }
        [TestMethod]
        public void Variabilità3()
        {
            double risultato = 2.64;
            double variabilità3 = CardioLibrary.calcolicuore.Variabilità_bpm(44);
            Assert.AreEqual(risultato, variabilità3);
        }
        [TestMethod]
        public void Variabilità4()
        {
            double risultato = 3.3;
            double variabilità4 = CardioLibrary.calcolicuore.Variabilità_bpm(55);
            Assert.AreEqual(risultato, variabilità4);
        }
        [TestMethod]
        public void Variabilità5()
        {
            double risultato = 2.16;
            double variabilità5 = CardioLibrary.calcolicuore.Variabilità_bpm(36);
            Assert.AreEqual(risultato, variabilità5);
        }
        [DataTestMethod]
        [DataRow(34, 2.04)]
        [DataRow(42, 2.52)]
        [DataRow(38, 2.28)]
        [DataRow(50, 3)]
        [DataRow(53, 3.18)]
        public void VariabilitàData(double bpm, double risposta_aspettata)
        {
            double VariabilitàData = CardioLibrary.calcolicuore.Variabilità_bpm(bpm);
            Assert.AreEqual(risposta_aspettata, VariabilitàData);
         

        }
        
    }
}
