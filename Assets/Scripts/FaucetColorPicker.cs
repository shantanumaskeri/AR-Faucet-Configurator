using UnityEngine;
using System.Collections;

public class FaucetColorPicker : MonoBehaviour 
{

	public Texture B96;
	public Texture G;
	public Texture BZ2;
	public Texture CP;
	public Texture TB;
	public Texture BV;
	public Texture BN;
	public Texture AF;
	public Texture BGD;
	public Texture PB;
	public Texture SN;
	public Texture TT;
	public Texture VNT;
	public Texture W0;

	GameObject go;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void ChangeMeshColor (string colorName)
	{
		go = GameObject.FindGameObjectWithTag ("Faucet");

		MeshRenderer[] mra = go.GetComponentsInChildren<MeshRenderer>();
		for (int i = 0; i<mra.Length; i++)
		{
			Material[] ma = mra[i].GetComponent<MeshRenderer>().materials;
			for (int j = 0; j<ma.Length; j++)
			{
				if (ma[j].name.Equals ("faucetMat (Instance)"))
				{
					switch (colorName)
					{
					case "B96":
						ma[j].SetTexture ("_DiffuseMap", B96);
						break;

					case "G":
						ma[j].SetTexture ("_DiffuseMap", G);
						break;

					case "BZ2":
						ma[j].SetTexture ("_DiffuseMap", BZ2);
						break;

					case "CP":
						ma[j].SetTexture ("_DiffuseMap", CP);
						break;

					case "TB":
						ma[j].SetTexture ("_DiffuseMap", TB);
						break;

					case "BV":
						ma[j].SetTexture ("_DiffuseMap", BV);
						break;

					case "BN":
						ma[j].SetTexture ("_DiffuseMap", BN);
						break;

					case "AF":
						ma[j].SetTexture ("_DiffuseMap", AF);
						break;

					case "BGD":
						ma[j].SetTexture ("_DiffuseMap", BGD);
						break;

					case "PB":
						ma[j].SetTexture ("_DiffuseMap", PB);
						break;

					case "SN":
						ma[j].SetTexture ("_DiffuseMap", SN);
						break;

					case "TT":
						ma[j].SetTexture ("_DiffuseMap", TT);
						break;

					case "VNT":
						ma[j].SetTexture ("_DiffuseMap", VNT);
						break;

					case "W0":
						ma[j].SetTexture ("_DiffuseMap", W0);
						break;
					}
				}
			}
		}
	}
}
