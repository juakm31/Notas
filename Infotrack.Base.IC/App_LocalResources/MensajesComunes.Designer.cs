﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infotrack.Base.IC.App_LocalResources {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MensajesComunes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MensajesComunes() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Infotrack.Base.IC.App_LocalResources.MensajesComunes", typeof(MensajesComunes).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se ha actualizado el registro correctamente.
        /// </summary>
        public static string ActualizacionExitosa {
            get {
                return ResourceManager.GetString("ActualizacionExitosa", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se ha eliminado el registro correctamente.
        /// </summary>
        public static string EliminacionExitosa {
            get {
                return ResourceManager.GetString("EliminacionExitosa", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se ha agregado el registro correctamente.
        /// </summary>
        public static string MensajeCreacionExitosa {
            get {
                return ResourceManager.GetString("MensajeCreacionExitosa", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se ha obtenido el registro correctamente.
        /// </summary>
        public static string RegistroObtenido {
            get {
                return ResourceManager.GetString("RegistroObtenido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se han obtenido los registros correctamente.
        /// </summary>
        public static string RegistrosObtenidos {
            get {
                return ResourceManager.GetString("RegistrosObtenidos", resourceCulture);
            }
        }
    }
}
