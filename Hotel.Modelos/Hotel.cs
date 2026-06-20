using System.Collections.Generic;

namespace Hotel.Modelos
{
    public class Hotel
    {
        private List<Reserva> reservas;

        public Hotel()
        {
            reservas = new List<Reserva>();
        }

        public void AgregarReserva(Reserva r)
        {
            reservas.Add(r);
        }

        public List<Reserva> ObtenerTodas()
        {
            return reservas;
        }

        public double CalcularIngresoTotal()
        {
            double total = 0;
            foreach (Reserva r in reservas)
            {
                total = total + r.CalcularTotal();
            }
            return total;
        }

        public Reserva ObtenerMayorDuracion()
        {
            if (reservas.Count == 0)
                return null;

            Reserva mayor = reservas[0];
            for (int i = 1; i < reservas.Count; i++)
            {
                if (reservas[i].GetNoches() > mayor.GetNoches())
                {
                    mayor = reservas[i];
                }
            }
            return mayor;
        }
    }
}