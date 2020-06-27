namespace deporte
{

    public class Jugadores
    {
        //Propoiedades 
        private int Id {get; set;}
        public string NombreApellido {get; set;}
        public int Edad {get; set;}
        public double Estatura {get; set;}
        public string PosicionJuego {get; set;}

        Deporte deporte = new Deporte{
            Nombre = "Futbol",
            TipoDeporte = "Balonpie",
            TiempoJuego = "90 minutos"
        };

        Equipo equipo = new Equipo {
             Nombre = "Los pollitos criollos"
        };




        public string Practica (){
            return deporte.Nombre;
             
        } 
        public string Presentarse ( ){
            return $"Hola soy conocido como {NombreApellido} tengo {Edad} y mido {Estatura}m, un gusto";
        }
        public string EquipoPertenece(){
            return $"Pertenezco al equipo {equipo.Nombre}";
        }
        public string DeportePractica (){
            return $"Pratico el deporte más popular. el {deporte.Nombre}, este deporte dura {deporte.TiempoJuego} se clasifica como el deporte {deporte.TipoDeporte} ";
        }
     
    }
    
}