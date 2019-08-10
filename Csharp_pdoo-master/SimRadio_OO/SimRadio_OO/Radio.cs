﻿/*
Programa:       SimRadio
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Enunciado al problema:
----------------------

Realice un programa en C# con interfaz gráfica en Windows Forms que simule 
el comportamiento de un radio FM.

El programa permitirá cambiar la frecuencia de la emisora a través de dos botones
(F+,F-) que realizarán incrementos de la frecuencia de a 1 MHz. Las frecuencias están
en el rango comprendido entre 88.9 y 107.9 MHz. El valor predeterminado para la frecuencia
actual cuando comienza el programa será de 88.9 MHz. Si se incrementa el valor 
por encima del límite superior, el valor siguiente será el de la frecuencia del límite 
inferior. De manera equivalente, si se decrementa por debajo del límite inferior, el valor
siguiente será el del límite superior. Con F+ y F- se podrá dar ciclos completos dentro
del rango de frecuencias especificado.

El programa permitirá cambiar el valor del volumen a través de dos botones (V+,V-), los cuales
realizarán incrementos de 1 unidad en un rango de valores entre 0 y 10. Si se llega a los
límites inferiores o superiores, los valores no podrán superar o decrementar dichos límites.
El valor predeterminado del volumen será 0.

El programa tendrá un botón de encendido y apagado, el cual no permitirá que las funciones
se ejecuten en caso de que el radio esté apagado. Cuando el radio está apagado, los valores
para la frecuencia y el volumen no se ven y los botones no funcionan 
*/

using System;

namespace SimRadio_OO
{
    class Radio
    {
        // los atributos de la clase
        private bool estado, accionMemoria;
        private float frecuencia;
        private int volumen;
        private float[] memorias;

        //Constructor de la clase
        public Radio()
        {
            estado = false;
            accionMemoria = false;
            frecuencia = 88.9f;
            volumen = 0;

            //Inicializamos las memorias, 5 frecuencias, con el valor predeterminado
            memorias = new float[5];
            for (int i = 0; i < memorias.Length; i++)
                memorias[i] = 88.9f;
        }

        #region Propiedades para los atributos

        /// <summary>
        /// Obtiene el valor del Estado del Radio (true -> encendido, false -> apagado)
        /// </summary>
        public bool Estado
        {
            get { return estado; }
        }

        /// <summary>
        /// Obtiene el valor de la acción de memoria (true -> guardando, false -> leyendo)
        /// </summary>
        public bool AccionMemoria
        {
            get { return accionMemoria; }
        }

        /// <summary>
        /// Obtiene o establece el valor del volumen del radio
        /// </summary>
        public int Volumen
        {
            get { return volumen; }
            set
            {
                //solo se asigna valor si está en el rango [0;10]
                if (value >= 0 && value <= 10)
                    volumen = value;
            }
        }

        /// <summary>
        /// Obtiene o establece el valor de la frecuencia actual del radio
        /// </summary>
        public float Frecuencia
        {
            get { return frecuencia; }
            set
            {
                //solo se asigna valor si está en el rango [88.9;17.9]
                if (value >= 88.9f && value <= 107.9f)
                    frecuencia = value;
            }
        }

        #endregion

        //Metodos para el cambio controlado de los atributos
        //Aqui se implementan las reglas de los requerimiento

        /// <summary>
        /// Cambia el estado del radio. Pasa de encendido a apagado según sea el caso
        /// </summary>
        public void CambiaEstado()
        {
            if (estado == true)
                estado = false;
            else
                estado = true;
        }

        /// <summary>
        /// Cambia el estado de la acción de las memorias. Pasa de leyendo a guardando según sea el caso
        /// </summary>
        public void CambiaAccionMemoria()
        {
            if (accionMemoria == true)
                accionMemoria = false;
            else
                accionMemoria = true;
        }

        /// <summary>
        /// Incrementa en una unidad el volumen solo hasta el valor máximo de 10
        /// </summary>
        public void IncrementaVolumen()
        {
            //sube el volumen si el volumen es menor que 10
            if (volumen < 10)
                volumen++;
        }

        /// <summary>
        /// Decrementa en una unidad el volumen solo hasta el valor mínimo de 0
        /// </summary>
        public void DecrementaVolumen()
        {
            //baja el volumen si el volumen es mayor que 0
            if (volumen > 0)
                volumen--;
        }

        /// <summary>
        /// Incrementa el valor de la frecuencia actual en 1 MHz
        /// </summary>
        public void IncrementaFrecuencia()
        {
            //si se incrementa por encima del límite superior
            //se devuelve al inferior. De lo contrario, incrementa en 1 MHz.
            if (frecuencia >= 107.9f)
                frecuencia = 88.9f;
            else
                frecuencia++;
        }

        /// <summary>
        /// Decrementa el valor de la frecuencia actual en 1 MHz
        /// </summary>
        public void DecrementaFrecuencia()
        {
            if (frecuencia <= 88.9f)
                frecuencia = 107.9f;
            else
                frecuencia--;
        }

        /// <summary>
        /// Procesa la memoria seleccionada para obtener o establecer la frecuencia actual del radio
        /// </summary>
        /// <param name="posicionMemoria"></param>
        public void ProcesaMemoriaFrecuencia(int posicionMemoria)
        {
            //Se valida el estado de la acción de la memoria
            // (true -> guardando, false -> leyendo)
            if (accionMemoria == false)
                //Si se está leyendo, se toma el valor de la memoria y se coloca como frecuencia actual
                frecuencia = memorias[posicionMemoria - 1]; //Desde la UI viene el número del botón, se ajusta a indice de arreglo
            else
            {
                //Si se está grabando, se toma el valor de la frecuencia actual y se coloca en la memoria especificada
                memorias[posicionMemoria - 1] = frecuencia; //Desde la UI viene el número del botón, se ajusta a indice de arreglo
                accionMemoria = false; // se vuelve a dejar en modo lectura después de la grabación
            }
        }
    }
}
