using DataAccess.EntityFW;
using Models.Entities;
using SDWeb.Utility;
using SDWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDWeb.Controllers
{
    public class AccountController : Controller
    {
        IUnitOfWork _unitOfWork;

        public AccountController( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            _unitOfWork.Add<User>(new User() { Email = "rgsdfgsdfg"});
            var list = _unitOfWork.Get<User>();

            _unitOfWork.Commit();
            return View();
        }

        public ActionResult Register() 
        {
            var registerModel = new UserView();
            return View(registerModel);
        }

        [HttpPost]
        public ActionResult Register(UserView user)
        {
            return View();
        }

        public ActionResult Captcha()
        {
            string code = new Random(DateTime.Now.Millisecond).Next(1111, 9999).ToString();
            Session["code"] = code;
            CaptchaImage captcha = new CaptchaImage(code, 110, 50);

            this.Response.Clear();
            this.Response.ContentType = "image/jpeg";

            captcha.Image.Save(this.Response.OutputStream, ImageFormat.Jpeg);

            captcha.Dispose();
            return null;
        }
	}
}