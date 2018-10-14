using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_HWTwo.Controllers
{
    public class DictionaryController : Controller
    {
        // GET: Dictionary
        public ActionResult Index()
        {

            Dictionary<int, string> DictList = new Dictionary<int, string>();

             string add2Dicionary()
            { string Tstring= "added Key number "+DictList.Count;
                DictList.Add(DictList.Count, Tstring );
                return Tstring;
            }

            string addBiglist()
            {
                int bigBumber = 1000;
                string Bstring = bigBumber+"items were added added";
                for(int i=0; i<=bigBumber; i++)
                {
                    add2Dicionary();
                };
                return Bstring;
            }
            Dictionary<int, string> DisplayDict()
            {
                return DictList;
            }

            string DeleteDictionary()
            {
                string Item1 = "An item was deleted, but which one?";
                if (DictList.Count==0)
                {
                    Item1 = "you dont have any dicts....";
                }
                else
                {
                    DictList.Remove(1);
                }
                
                return Item1;
            }

            string ClearDictionary()
            {
                string DictClear = "Your Dict is clear... sad you had some good items here ;(";

                DictList.Clear();
                return DictClear;

            }
            string FindAdict(int Dict)
            {
                string assHole = "Hey ass whole you deleted dict number " + Dict;
                String foundValue = DictList[Dict];
                return assHole;
            }

            return View();
        }
    }
}