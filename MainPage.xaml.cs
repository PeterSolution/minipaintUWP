﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using static System.Net.Mime.MediaTypeNames;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415


namespace zadanie1
{


    public sealed partial class MainPage : Page
    {
        Point punkt;
        SolidColorBrush pedzel = new SolidColorBrush(Colors.Red);
        SolidColorBrush pedzel2 = new SolidColorBrush(Colors.Blue);
        SolidColorBrush pedzel3 = new SolidColorBrush(Colors.Black);
        SolidColorBrush pedzel4 = new SolidColorBrush(Colors.Green);
        List<int> idlinia = new List<int>();

        int idlin = 0;

        bool czyrysujeprosto = false;
        bool czyrysujedowolnie = false;


        Point startpoint;
        Point endpoint;

        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;
        int flag4 = 0;

        int thikness = 2;




        Stack<Line> linie = new Stack<Line>();

        public MainPage()
        {

            this.InitializeComponent();


        }

        private void rdbDowolny_Checked(object sender, RoutedEventArgs e)
        {


            czyrysujedowolnie = true;

            czyrysujeprosto = false;
        }
        public void canvclick(object sender, PointerRoutedEventArgs e)
        {
            startpoint = e.GetCurrentPoint(this).Position;
            flag3 = 1;

        }

        private void canv_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (czyrysujeprosto)
            {
                endpoint = e.GetCurrentPoint(this).Position;
                if (flag4 == 0)
                {
                    Line linia = new Line
                    {
                        X1 = startpoint.X - 5,
                        Y1 = startpoint.Y - 137,
                        X2 = endpoint.X - 5,
                        Y2 = endpoint.Y - 137,
                        Stroke = pedzel,
                        StrokeThickness = thikness,
                    };
                    canv.Children.Add(linia);
                    linie.Push(linia);

                }
                else
                {
                    if (flag4 == 1)
                    {
                        Line linia = new Line
                        {
                            X1 = startpoint.X - 5,
                            Y1 = startpoint.Y - 137,
                            X2 = endpoint.X - 5,
                            Y2 = endpoint.Y - 137,
                            Stroke = pedzel2,
                            StrokeThickness = thikness,
                        };
                        canv.Children.Add(linia);
                        linie.Push(linia);
                    }
                    else
                    {
                        if (flag4 == 2)
                        {
                            Line linia = new Line
                            {
                                X1 = startpoint.X - 5,
                                Y1 = startpoint.Y - 137,
                                X2 = endpoint.X - 5,
                                Y2 = endpoint.Y - 137,
                                Stroke = pedzel3,
                                StrokeThickness = thikness,
                            };
                            canv.Children.Add(linia);
                            linie.Push(linia);
                        }
                        else
                        {
                            Line linia = new Line
                            {
                                X1 = startpoint.X - 5,
                                Y1 = startpoint.Y - 137,
                                X2 = endpoint.X - 5,
                                Y2 = endpoint.Y - 137,
                                Stroke = pedzel4,
                                StrokeThickness = thikness,
                            };
                            canv.Children.Add(linia);
                            linie.Push(linia);
                        }
                    }
                }
                btnus.IsEnabled = true;

                idlinia.Add(idlin);
            }

            idlin++;
            flag3 = 0;
        }

        private void rdbProsty_Click(object sender, RoutedEventArgs e)
        {
            if (flag1 == 0)
            {
                rdbProsty.IsChecked = true;
                czyrysujeprosto = true;
                czyrysujedowolnie = false;
                flag1 = 1;
                flag2 = 0;
            }
            else
            {
                flag1 = 0;
                flag2 = 0;
                rdbProsty.IsChecked = false;
                czyrysujedowolnie = false;
            }
        }

        private void rdbDowolny_Click(object sender, RoutedEventArgs e)
        {
            if (flag2 == 0)
            {
                rdbDowolny.IsChecked = true;
                czyrysujeprosto = false;
                czyrysujedowolnie = true;
                flag2 = 1;
                flag1 = 0;
            }
            else
            {
                flag2 = 0;
                flag1 = 0;

                rdbDowolny.IsChecked = false;
                czyrysujedowolnie = false;
            }
        }

        private void canv_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (czyrysujedowolnie == true && flag3 == 1)
            {
                endpoint = e.GetCurrentPoint(this).Position;
                if (flag4 == 0)
                {
                    Line linia = new Line
                    {
                        X1 = startpoint.X - 5,
                        Y1 = startpoint.Y - 137,
                        X2 = endpoint.X - 5,
                        Y2 = endpoint.Y - 137,
                        Stroke = pedzel,
                        StrokeThickness = thikness,
                    };
                    canv.Children.Add(linia);
                    startpoint = endpoint;
                    linie.Push(linia);
                }
                else
                {
                    if (flag4 == 1)
                    {
                        Line linia = new Line
                        {
                            X1 = startpoint.X - 5,
                            Y1 = startpoint.Y - 137,
                            X2 = endpoint.X - 5,
                            Y2 = endpoint.Y - 137,
                            Stroke = pedzel2,
                            StrokeThickness = thikness,
                        };

                        canv.Children.Add(linia);
                        startpoint = endpoint;
                        linie.Push(linia);
                    }
                    else
                    {
                        if (flag4 == 2)
                        {
                            Line linia = new Line
                            {
                                X1 = startpoint.X - 5,
                                Y1 = startpoint.Y - 137,
                                X2 = endpoint.X - 5,
                                Y2 = endpoint.Y - 137,
                                Stroke = pedzel3,
                                StrokeThickness = thikness,
                            };

                            canv.Children.Add(linia);
                            startpoint = endpoint;
                            linie.Push(linia);
                        }
                        else
                        {
                            Line linia = new Line
                            {
                                X1 = startpoint.X - 5,
                                Y1 = startpoint.Y - 137,
                                X2 = endpoint.X - 5,
                                Y2 = endpoint.Y - 137,
                                Stroke = pedzel4,
                                StrokeThickness = thikness,

                            };

                            canv.Children.Add(linia);
                            startpoint = endpoint;
                            linie.Push(linia);

                        }
                    }
                }


                btnus.IsEnabled = true;

                idlinia.Add(idlin);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            flag4 = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            flag4 = 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            flag4 = 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            flag4 = 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            int ostatniaLiczba = idlinia.Last(); 
            int liczbaWystapienOstatniej = idlinia.Count(x => x == ostatniaLiczba); 
            for (int i = 0; i < liczbaWystapienOstatniej; i++)
            {
                Line und = linie.Pop();
                canv.Children.Remove(und);
                idlinia.RemoveAt(idlinia.Count - 1);
            }



            if (linie.Count == 0)
            {
                btnus.IsEnabled = false;
            }


        }


        private void TextBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            if (int.TryParse(txtgrub.Text, out int liczba))
            {
                
                thikness = Convert.ToInt32(txtgrub.Text);
            }

        }
    }
}
