

namespace MyAspNetCoreApp.HRAdministraction
{
    public static class FactoryPettern<K,T>where T:class, K,new()
    {
        public static K GetInstance()
        {
            K objK;
            objK= new T();
            return objK;
        }
    }
}