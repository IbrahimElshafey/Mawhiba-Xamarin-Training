using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using MawhibaSample.Common;
using MawhibaSample.Localization;
using MawhibaSample.Services;
using Refit;
using Xamarin.Forms;

namespace MawhibaSample
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

    }
}
