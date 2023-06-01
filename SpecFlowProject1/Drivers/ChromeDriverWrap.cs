using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Drivers
{
    
    public static class ChromeDriverWrap
    {
        private static readonly ChromeDriver driver = new ChromeDriver();

        public static ChromeDriver Driver { get => driver; }
    }
}
