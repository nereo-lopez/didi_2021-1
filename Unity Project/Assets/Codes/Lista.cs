using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Lista : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Definimos a quien queremos buscar//
        string alumno = "Alfonso";
        //Array Lista//
        string[] listaAlumnos = {"Abimael","Araceli","Brandon","Cristian","Daniel","Edgar","Edgar","Erick","Felix","Isaac","Ivan","Jorge","Jose","Luis","Luis Eloy","Luis Fernando","Miguel","Nereo","Raul","Sergio"};
        //Uso de algoritmo de búsqueda lineal
        bool found = false;
        int left = 0,right = listaAlumnos.Length - 1;
        while(left<=right && ! found)
        {
            int center = left+(right-left)/2;
            if(listaAlumnos[center]==alumno)
                found = true;
            else if (listaAlumnos[center]!=alumno)
                left = center+1;
            else
                right = center-1;
        }
        //Resultado
        if (found)
            Debug.Log("Verdadero");
        else
            Debug.Log("False");      
    }

    //Time Complexity: log2(n)
}
