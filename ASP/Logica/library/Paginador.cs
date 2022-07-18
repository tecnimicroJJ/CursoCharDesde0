﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.library
{
    public class Paginador <T>
    {
        private List<T> _dataList;
        private Label _label;
        private static int maxReg, _reg_por_pagina, pageCount, numPagi = 1;

        public Paginador(List<T> dataList, Label label, int reg_por_pagina)
        {
            _dataList = dataList;
            _label = label; 
            _reg_por_pagina = reg_por_pagina;
            cargarDatos();
        }

        private void cargarDatos()
        {
            //primera pagina
            numPagi = 1;
            //numero de resgistros
            maxReg = _dataList.Count;
            //Dividimos el numero de registro en por el numero de registro por paginas ,para 
            //aveiguar el numero de paginas totales.
            pageCount = (maxReg / _reg_por_pagina);
            if( (maxReg % _reg_por_pagina) > 0)
            {
                pageCount += 1;
            }
            //imprime el numero de paginas de estudiantes que existen.
            _label.Text = $"Paginas 1/{pageCount}";
        }

        public int primero()
        {
            numPagi = 1;
            _label.Text = $"Paginas {numPagi}/{pageCount}";
            return numPagi;
        }

        public int anterior()
        {
            if(numPagi > 1) 
            {
                numPagi -=1;
                _label.Text = $"Paginas {numPagi}/{pageCount}";
            }

            return numPagi;
        }

        public int siguiente()
        {
            if(numPagi == pageCount)
                numPagi -= 1;
            if(numPagi < pageCount)
            {
                numPagi += 1;
                _label.Text = $"Paginas {numPagi}/{pageCount}";
            }

            return numPagi;
        }

        public int ultimo() 
        {
            numPagi = pageCount;
            _label.Text = $"Paginas{ numPagi}/ {pageCount}";
            return numPagi; 
        }

    }
}
