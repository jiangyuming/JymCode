using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HighCharts.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        /// <summary>
        /// 导航页1
        /// </summary>
        /// <returns></returns>
        public ActionResult Home()
        {
            return View();
        }

        /// <summary>
        /// 导航页2
        /// </summary>
        /// <returns></returns>
        public ActionResult Show()
        {
            return View();
        }

        /// <summary>
        /// 目前空白
        /// </summary>
        /// <returns></returns>
        public ActionResult Test()
        {
            return View();
        }

        /// <summary>
        /// 多Y轴1
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

         //<summary>
         //多Y轴 2
         //</summary>
         //<returns></returns>
        public ActionResult Test2()
        {
            return View();
        }

        //<summary>
        //多Y轴 3
        //</summary>
        //<returns></returns>
        public ActionResult Test3()
        {
            return View();
        }

        //<summary>
        //多Y轴 4
        //</summary>
        //<returns></returns>
        public ActionResult Test4()
        {
            return View();
        }

        //<summary>
        //多Y轴 5
        //</summary>
        //<returns></returns>
        public ActionResult Test5()
        {
            return View();
        }

        //<summary>
        //XXX地下水水位过程线 折线图
        //</summary>
        //<returns></returns>
        public ActionResult Test6()
        {
            return View();
        }

        //<summary>
        //XXX地下水水位时间序列图 柱形图
        //</summary>
        //<returns></returns>
        public ActionResult Test7()
        {
            return View();
        }

        //<summary>
        //XXX地下水埋深过程线 折线图
        //</summary>
        //<returns></returns>
        public ActionResult Test8()
        {
            return View();
        }
 
        //<summary>
        //XXX地下水埋深时间序列图 折线图
        //</summary>
        //<returns></returns>
        public ActionResult Test9()
        {
            return View();
        }
       
        //<summary>
        // XX年至XX年XXX地下水埋深过程线
        //</summary>
        //<returns></returns>
        public ActionResult Test10()
        {
            return View();
        }
        
        //<summary>
        // XX年至XX年XXX地下水埋深比较图
        //</summary>
        //<returns></returns>
        public ActionResult Test11()
        {
            return View();
        }
     
        //<summary>
        //    XX年至XX年XXX地下水水位过程线
        //</summary>
        //<returns></returns>
        public ActionResult Test12()
        {
            return View();
        }
       
        //<summary>
        //   XX年至XX年XXX地下水水位比较图
        //</summary>
        //<returns></returns>
        public ActionResult Test13()
        {
            return View();
        }
       
         //<summary>
        //    地下水开采量时间序列图
        //</summary>
        //<returns></returns>
        public ActionResult Test14()
        {
            return View();
        }
      
         //<summary>
        //      地下水开采量比较图
        //</summary>
        //<returns></returns>
        public ActionResult Test15()
        {
            return View();
        }

        /// <summary>
        /// 比例分配图1
        /// </summary>
        /// <returns></returns>
        public ActionResult Test16()
        {
            return View();
        }

        /// <summary>
        /// 比例分配图2
        /// </summary>
        /// <returns></returns>
        public ActionResult Test17()
        {
            return View();
        }
       
        /// <summary>
        ///  降水量时间序列图1
        /// </summary>
        /// <returns></returns>
        public ActionResult Test18()
        {
            return View();
        }
      
        /// <summary>
        ///    降水量时间序列图2
        /// </summary>
        /// <returns></returns>
        public ActionResult Test19()
        {
            return View();
        }
        
        /// <summary>
        ///   XX年与XX年行政分区降水量比较图
        /// </summary>
        /// <returns></returns>
        public ActionResult Test20()
        {
            return View();
        }
        
        /// <summary>
        ///  分时段蓄变量分析图
        /// </summary>
        /// <returns></returns>
        public ActionResult Test21()
        {
            return View();
        }


        /// <summary>
        /// 基本折线图
        /// </summary>
        /// <returns></returns>
        public ActionResult highcharts_line_basic()
        {
            return View();
        }

        /// <summary>
        /// 基本折线图 Y轴对称
        /// </summary>
        /// <returns></returns>
        public ActionResult highcharts_line_basic_y_opposite()
        {
            return View();
        }

        /// <summary>
        /// 基本折线图 Y轴对称 两条折线数据
        /// </summary>
        /// <returns></returns>
        public ActionResult highcharts_line_basic_y_opposite_moredata()
        {
            return View();
        }

        public ActionResult highcharts_line_ajax()
        {
            return View();
        }

        /// <summary>
        /// Highcharts 带有数据标签曲线图表
        /// </summary>
        /// <returns></returns>
        public ActionResult highcharts_line_labels()
        {
            return View();
        }

        /// <summary>
        /// Highcharts 双Y轴, 柱形图，线条图组合
        /// </summary>
        /// <returns></returns>
        public ActionResult highcharts_combinations_dualaxes()
        {
            return View();
        }




        /// <summary>
        /// Highcharts 双Y轴, 柱形图，线条图组合  ，多一条数据折线
        /// </summary>
        /// <returns></returns>
        public ActionResult highcharts_combinations_dualaxes_change()
        {
            return View();
        }

        /// <summary>
        /// 基本柱形图
        /// </summary>
        /// <returns></returns>
        public ActionResult highcharts_column_basic()
        {
            return View();
        }

        /// <summary>
        /// 基本柱形图  多条数据
        /// </summary>
        /// <returns></returns>
        public ActionResult highcharts_column_basic_moredata()
        {
            return View();
        }



       



    }
}
