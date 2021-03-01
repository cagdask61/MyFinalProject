using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";

        public static string ProductCountofCategoryError = "Bir kategoride en fazla 10 ürün olabilir";

        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için ürün eklenemiyor";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public  static string UserRegistered = "Kayıt işlemi başarılı";
        public  static string UserAlreadyExists = "";
        public  static object AccessTokenCreated = "";
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static User UserNotFound;
    }
}
