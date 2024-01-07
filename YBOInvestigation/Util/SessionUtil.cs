﻿using Newtonsoft.Json;
using YBOInvestigation.Classes;

namespace YBOInvestigation.Util
{
    public class SessionUtil
    {
        public static void SetLoginUserInfo(HttpContext httpContext, LoginUserInfo userInfo)
        {
            if (httpContext == null || userInfo == null)
            {
                throw new ArgumentNullException();
            }

            string userInfoJson = JsonConvert.SerializeObject(userInfo);
            httpContext.Session.SetString("LoginUserInfo", userInfoJson);
        }

        public static LoginUserInfo GetLoginUserInfo(HttpContext httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException();
            }

            string userInfoJson = httpContext.Session.GetString("LoginUserInfo");

            if (userInfoJson != null)
            {
                return JsonConvert.DeserializeObject<LoginUserInfo>(userInfoJson);
            }

            return null;
        }

        public static bool IsRememberMe(HttpContext httpContext)
        {
            LoginUserInfo loginUserInfo = GetLoginUserInfo(httpContext);
            return ( (loginUserInfo != null && loginUserInfo.RememberMe));

        }

        public static bool IsActiveSession(HttpContext httpContext)
        {
            LoginUserInfo loginUserInfo = GetLoginUserInfo(httpContext);
            return loginUserInfo != null;

        }

    }
}
