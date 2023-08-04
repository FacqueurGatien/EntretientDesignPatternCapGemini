using AuFeuLesPatternsModel;

namespace AuFeuLesPatternVisiteur
{
    public interface IVisiteur
    {
        public EnumTypeVisiteur GetType();
        public string Visit(Camion _camion);
        public string Visit(Bombardier _bombardier);
    }
}