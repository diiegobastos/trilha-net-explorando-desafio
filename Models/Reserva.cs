namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
          /*  if (hospedes == null || hospedes.Count == 0)
            {
                throw new ArgumentException("A lista de hóspedes não pode ser nula ou vazia.");
            }
            if (Suite == null)
            {
                throw new InvalidOperationException("A suíte deve ser cadastrada antes de cadastrar os hóspedes.");
            }
            */
            if (Suite.Capacidade >= hospedes.Count)
            {
                // Atribui a lista de hóspedes à propriedade Hospedes   
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new InvalidOperationException("A quantidade de hóspedes excede a capacidade da suíte.");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // Se a lista de hóspedes for nula, retorna 0
            return Hospedes.Count;
            //return Hospedes?.Count ?? 0;

        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;


            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.1m; // Aplicando 10% de desconto
            }
            return valor;
        }
    }
}