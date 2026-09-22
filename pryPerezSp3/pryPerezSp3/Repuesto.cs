using System;
using System.Collections.Generic;
using System.Text;

namespace pryPerezSp3
{
    internal class Repuesto
    {
        public string Marca { get; set; }
        public string Origen { get; set; }
        public int NroRepuesto { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }

        public override string ToString()
        {
            return $"{NroRepuesto} - {Descripcion} - ${Precio}";
        }
    }
}
