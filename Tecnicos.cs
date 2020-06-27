namespace deporte
{
    public class Tecnicos
    {
        private int Id {get; set;}
        public string Nombre {get; set;}
        public int Edad {get; set;}
        public int AñosProfesión {get; set;}

        Deporte deporte = new Deporte {
            Nombre = "Basquetboll"
        };

        Equipo equipos = new Equipo {
            Nombre = "Los azules electricos",
            Capitan = "Juan Dionizo",
        };

        public string Saludar (){
            return $"Hola mi nombre es {Nombre}, tengo {Edad} y soy tecnico desde hace {AñosProfesión} años ";
        }

        public string DeporteEnseña (){
            return $"Yo ahora imparto conocimintos y estrategias sobre el deporte {deporte.Nombre}";
        }

        public string EquiposCargo(){
            return $"{equipos.Nombre} son los que estan a mi cargo, cuyo capitan es {equipos.Capitan}";
        }

        public string EstuiantesCargo (string nombre){
            return $"{nombre} fue uno de mis alumnos";
        }  
    }
}