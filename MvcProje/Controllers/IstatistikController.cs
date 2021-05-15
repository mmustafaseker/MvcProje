﻿using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        Context _context = new Context();
        public ActionResult Index()
        {
            var totalCategory = _context.Categories.Count(); //Toplam Kategori Sayisi
            ViewBag.totalNumberOfCategories = totalCategory;

            var softwareCategory = _context.Headings.Count(x => x.CategoryId == 2); // Yazilim Kategorisi (8) baslik sayisi
            ViewBag.softwareCategoryTitleNumber = softwareCategory;

            var writerNameSortByA = _context.Writers.Count(x => x.WriterName.Contains("a")); // Yazar adinda "a" harfi gecen yazar sayisi
            ViewBag.writerNameSortByA = writerNameSortByA;

            var mostTitles = _context.Headings.Max(x => x.Category.CategoryName); // En fazla basliga sahip kategori adi
            ViewBag.categoryNameWithTheMostTitles = mostTitles;

            var categoryStatusTrue = _context.Categories.Count(x => x.CategoryStatus == true); // Kategoriler tablosundaki aktif kategori sayisi
            ViewBag.activeCategories = categoryStatusTrue;

            return View();
        }
    }
}