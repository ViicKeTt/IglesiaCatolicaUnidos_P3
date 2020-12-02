using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IglesiaCatolicaUnidos.Data
{
    public class Integrante
    {
        public Guid IntegranteID { get; set; }
        public Guid MyUsuarioID { get; set; }
        public string Sexo { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string PaisNacimiento { get; set; }
        public string CiudadNacimiento { get; set; }
        public string PaisResidenciaActual { get; set; }
        public string CiudadResidenciaActual { get; set; }
        public string Direccion { get; set; }
        public long Telefono { get; set; }
        public long Celular { get; set; }
        public string Correo { get; set; }
        public string TipoDocumento { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string EstadoCivil { get; set; }
        public string NombrePareja { get; set; }
        public string Hijos { get; set; }
        public int N_hijos { get; set; }
        public string Profesion { get; set; }
        public string NombreEmpresa { get; set; }
        public string OcupacionActual { get; set; }
        public long TelefonoCelular2 { get; set; }
        public string Nivel { get; set; }
        public string Suspendido { get; set; }
        public DateTime FechaConversion { get; set; }
        public DateTime FechaBautismo { get; set; }
        public DateTime FechaAceptacionIglesia { get; set; }
        public string DenominacionReligiosa { get; set; }
        public string NombreIglesiaActual { get; set; }

        public string TiempoDondeseCongregaba { get; set; }

        public string IglesiaAnterior { get; set; }
        public string NombrePastorActual { get; set; }
        public string Diciplinado { get; set; }
        public int N_Diciplinado { get; set; }
        public string Causas { get; set; }
        public string FuncionesActuales { get; set; }
        public string MinisteriosServidos { get; set; }
        public string MayorFrutoMinisterios { get; set; }
        public string LLamadoMinisterio { get; set; }
        public string Metas { get; set; }
        public string RespaldoAutoridades_Ecle { get; set; }
        // <!------------------------Datos Academicos-------------------------->
        public string NivelEstudio { get; set; }
        public string Expulsado { get; set; }
        public string RazonExpulsacion { get; set; }

    }
}
