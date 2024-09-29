using UnityEngine;  
using UnityEngine.UI;

public class Kont : MonoBehaviour
{
    public string Nama;
    public float TinggiBadan;
    public int Umur;
    public char Inisial;
    public enum vote { sip, yoi, yes };
    public vote Komentar;
    string myText;
    public Vector2 Koordinat2D;
    public Vector2 Koordinat3D;

    void Start()
    {
        if (Komentar == vote.yoi)
        {
            myText = "uhuuyy!";
        }

        else
        {
            myText = "okelah";
        }
        Debug.Log("Nama : " + Nama + "\nNIM : 023221473888"+ "\nTinggi Badan : " + TinggiBadan + "\nUmur : " + Umur + "\nInisial : " 
            + Inisial + "\n" + "\nKomentar : " + myText + "\n2D : " + Koordinat2D.ToString() + "\n3D : " + Koordinat3D);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
