﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ViewModels.BaseClass;
using RectangleProject.Models;
using System.Windows;

namespace RectangleWpfProject.ViewModels
{
    class RectangleViewModel : ViewModelBase
    {
        private Rectangle rectangle;


        public RectangleViewModel()
        {
            rectangle = new Rectangle(1, 1);
        }

        public string SideA
        {
            get
            {
                return rectangle.SideA.ToString();
            }

            set
            {
                try
                {
                    double side = Convert.ToDouble(value);
                    rectangle.SideA = side;
                }
                catch (Exception e)
                {
                }
            }
        }

        public string SideB
        {
            get
            {
                return rectangle.SideB.ToString();
            }

            set
            {
                try
                {
                    double side = Convert.ToDouble(value);
                    rectangle.SideB = side;
                }
                catch (Exception e)
                {
                }
            }
        }

        public string Perimeter
        {
            get
            {
                double roundedPerimeter = Math.Round(rectangle.Perimeter, 2);
                return "A téglalap kerülete: " + roundedPerimeter.ToString() + " méter.";
            }
        }

        public string Area
        {
            get
            {
                double roundedArea = Math.Round(rectangle.Area, 2);
                return "A téglalap területe: " + roundedArea.ToString() + " négyzetméter.";
            }
        }
    }
}
