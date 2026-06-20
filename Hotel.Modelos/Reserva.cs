namespace Hotel.Modelos
{
    public class Reserva
    {
        private string cliente;
        private int habitacion;
        private string fechaIngreso;
        private int noches;
        private double precioPorNoche;

        public Reserva(string cliente, int habitacion, string fechaIngreso, int noches, double precioPorNoche)
        {
            this.cliente = cliente;
            this.habitacion = habitacion;
            this.fechaIngreso = fechaIngreso;
            this.noches = noches;
            this.precioPorNoche = precioPorNoche;
        }

        public string GetCliente() { return cliente; }
        public int GetHabitacion() { return habitacion; }
        public string GetFechaIngreso() { return fechaIngreso; }
        public int GetNoches() { return noches; }
        public double GetPrecioPorNoche() { return precioPorNoche; }

        public double CalcularTotal()
        {
            return noches * precioPorNoche;
        }

        public override string ToString()
        {
            return "Cliente: " + cliente + " | Habitacion: " + habitacion +
                   " | Ingreso: " + fechaIngreso + " | Noches: " + noches +
                   " | Precio/noche: " + precioPorNoche + " | Total: " + CalcularTotal();
        }
    }
}