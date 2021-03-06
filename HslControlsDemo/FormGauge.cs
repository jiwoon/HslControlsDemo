﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormGauge : Form
    {
        public FormGauge( )
        {
            InitializeComponent( );
        }

        private void FormGauge_Load( object sender, EventArgs e )
        {
            random = new Random( );
            timer = new Timer( );
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start( );
        }

        private void Timer_Tick( object sender, EventArgs e )
        {
            hslGauge1.Value = Math.Round( random.NextDouble( ) * 100, 2 );
            hslGauge2.Value = Math.Round( random.NextDouble( ) * 10, 2 );
            hslGauge3.Value = Math.Round( random.NextDouble( ) * 100, 2 );
            hslGauge4.Value = Math.Round( random.NextDouble( ) * 8, 2 );
            hslGauge5.Value = Math.Round( random.NextDouble( ) * 220, 2 );
        }

        private Timer timer = null;
        private Random random = null;
    }
}
