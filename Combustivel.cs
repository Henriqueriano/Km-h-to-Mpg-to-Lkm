namespace ExercicioUm
{
    public class Combustivel
    {
        public float consumo { get; set; }

        public float ConverterMPG()
        {
            float varConsumo = consumo * 2.3521458357139f;
            return varConsumo;
        }

        public float ConverterLkm()
        {
            float varConsumo = 100 / consumo;
            return varConsumo;
        }
    }
}
