namespace siraTabanliOyun
{
    public class Program 
    {
        static void Main(string[] args)
        {

            // TR - Konsol ekranı boyutu ve başlığı 
            // EN - Size of Console and Console Title
            Console.SetWindowSize(120, 30);
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Sıra Tabanlı Oyun - YÇAA";
            Console.WindowHeight = 30;
            
            
            // TR - Buradaki değerleri değiştirebilirsin
            // EN - You can change the value of these variables

            int playerHP = 100;
            int enemyHP = 100;


            // TR - Oyun döngüsü burada başlıyor
            // EN - Game Loop starts here
            while (playerHP > 0 && enemyHP > 0)
            {
                Console.WriteLine($"-- Oyuncu Sırası -- \nSaldırı için 'W' yuşuna; İyileşmek için 'Q' tuşuna basınız.");
                char secim = Convert.ToChar(Console.ReadLine().ToUpper());
                
                    if (secim == 'W')
                        {
                            Console.WriteLine("Saldırı türünü seçiniz : \n1.Hafif Saldırı\n2.Normal Saldırı\n3.Ağır Saldırı ");
                            int saldiriTuru = Convert.ToInt32(Console.ReadLine());
                            
                            // TR - Saldırı Türü
                            // EN - Type of Attack 
                            switch (saldiriTuru)
                            {

                                // TR - Hafif Saldırı
                                // EN - Light Attack
                                case 1:
                                Random saldiri1 = new Random();
                                int oyuncuHafifSaldiri = saldiri1.Next(0,15);
                                enemyHP -= oyuncuHafifSaldiri;

                                Console.WriteLine($"Düşmana {oyuncuHafifSaldiri} değerinde hasar verildi.");
                                Console.WriteLine($"Oyuncu Can Puanı : {playerHP}\nDüşman Can Puanı : {enemyHP}"); 
                                break;
                                
                                // TR - Normal Saldırı
                                // EN - Normal Attack
                                case 2:
                                Random saldiri2 = new Random();
                                int oyuncuNormalSaldiri = saldiri2.Next(10,25);
                                enemyHP -= oyuncuNormalSaldiri;

                                Console.WriteLine($"Düşmana {oyuncuNormalSaldiri} değerinde hasar verildi.");
                                Console.WriteLine($"Oyuncu Can Puanı : {playerHP}\nDüşman Can Puanı : {enemyHP}"); 
                                break;

                                
                                // TR - Ağır Saldırı
                                // EN - Heavy Attack
                                case 3:
                                Random saldiri3 = new Random();
                                int oyuncuAgirSaldiri = saldiri3.Next(20,35);
                                enemyHP -= oyuncuAgirSaldiri;

                                Console.WriteLine($"Düşmana {oyuncuAgirSaldiri} değerinde hasar verildi.");
                                Console.WriteLine($"Oyuncu Can Puanı : {playerHP}\nDüşman Can Puanı : {enemyHP}");
                                break;
                            }

                            // TR - Düşman Saldırısı
                            // EN - Enemy's Attack
                            Console.WriteLine("Düşman Saldırı Yapıyor");
                            Thread.Sleep(1000);

                            Random dusmanSaldiri = new Random();
                            int dusmanSaldiri1 = dusmanSaldiri.Next(0,20);
                            playerHP -= dusmanSaldiri1;

                            Console.WriteLine($"Düşman {dusmanSaldiri} değerinde hasar verdi.");
                            Console.WriteLine($"Oyuncu Can Puanı : {playerHP}\nDüşman Can Puanı : {enemyHP}");
                        }

                    else if  (secim == 'Q')
                    {
                        // TR - İyileşme
                        // EN - Healing 
                        Random iyilesme = new Random();
                        int oyuncuIyilesme = iyilesme.Next(5,10);
                        playerHP += oyuncuIyilesme;
                        Console.WriteLine($"{oyuncuIyilesme} değerinde Can Puanı artırılmıştır.");
                        Console.WriteLine($"Oyuncu Can Puanı : {playerHP}\nDüşman Can Puanı : {enemyHP}");

                        // TR - Oyuncunun Can Puanını 100 değerinde sabitleme
                        // EN - Make sure stable Player's HP at 100 value

                        if (playerHP > 100)
                        {
                            playerHP = 100;
                            Console.WriteLine($"Can Puanınız {playerHP}");
                        }

                    }
                    else 
                    {
                        Console.WriteLine("Yanlış tuşa bastınız. Tekrar Deneyiniz.");
                    }
            }

            // TR - Oyun Bitme Durumu
            // EN - Game Over Message
            if (playerHP <= 0)
            {
                Console.WriteLine("Öldün");
            }
            else 
            {
                Console.WriteLine("Düşman öldürüldü");
            }

            // TR - Konsol Kapatma Bölümü
            // EN - Console Closing Section
            Console.WriteLine($"Oyun Bitti Çıkış yapılıyor");
            Thread.Sleep(1500);
        }
    }
}