﻿using Do_an_TMDT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Do_an_TMDT.ViewModels
{
    public class HomeVM
    {
        public List<MatHangHome> MatHangs { get; set; }
        public List<ThuongHieu> TH { get; set; }
        public int SoLuong { get; set; }
        public string DiaChi { get; set; }
        public string key { get; set; }
        public string TenNguoiNhan { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }


    }
}
