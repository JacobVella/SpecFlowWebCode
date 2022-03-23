//using OpenQA.Selenium;
//using System.Net;

//namespace SpecFlowWeb
//{
//    public class SearchKeyWord
//    {
//        public string _keyword { get; set; }

//        public SearchKeyWord()
//        {

//            searchPage();
//        }

//        public void SetKeyword()
//        {
//            //this._keyword = "dog";
//        }

//        public void searchPage()
//        {
//            string someURL = "https://www.google.com/";
//            string webPageData = null;
//            int numfound = 0;
//            HttpClient client = new HttpClient();
//            using (HttpResponseMessage response = client.GetAsync(someURL).Result)
//            {
//                using (HttpContent content = response.Content)
//                {
//                    var json = content.ReadAsStringAsync().Result;
//                    webPageData = json;
//                }
//            }

//            var containsWord = webPageData.Contains(_keyword);
//            if (containsWord)
//            {
//                foreach (int numOfKeyWord in webPageData)
//                {
//                    numfound++;
//                }

//            }


//        }


//    }
//}