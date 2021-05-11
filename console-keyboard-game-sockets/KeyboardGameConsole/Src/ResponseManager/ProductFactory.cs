using KeyboardGameConsole.Src.ResponseManager.ResponseDict;
using KeyboardGameConsole.Src.ResponseManager.ResponseList;

namespace KeyboardGameConsole.Src.ResponseManager
{
    public class ProductFactory
    {
        public static AbstractFactory GetFactory(string factory)
        {
            switch (factory)
            {
                case "FactoryDict":
                    return new ResponseDictFactory();

                case "FactoryList":
                    return new ResponseListFactory();
                default:
                    return null;
            }
        }
    }
}
