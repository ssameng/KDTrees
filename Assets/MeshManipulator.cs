﻿using UnityEngine;
using System.Collections;

public class MeshManipulator : MonoBehaviour {

	public Mesh mesh;
	private Vector3[] originalVerts;
	private Vector3[] currentVerts;
	private Color[] colors;

	void Awake(){
		mesh = gameObject.GetComponent<MeshFilter>().mesh;
		originalVerts = new Vector3[mesh.vertices.Length];
		currentVerts = new Vector3[mesh.vertices.Length];
		for(int i = 0; i < mesh.vertices.Length; i++){
			originalVerts[i] = mesh.vertices[i];
			currentVerts[i] = mesh.vertices[i];
		}
		colors = new Color[mesh.vertices.Length];
	}

	public void SetScale(float scale){

		for(int i = 0; i < mesh.vertices.Length; i++){
			currentVerts[i] = originalVerts[i] * scale;
		}
		mesh.vertices = currentVerts;

	}

	public void SetColor(Color c){
		for(int i = 0; i < colors.Length; i++){
			colors[i] = c;
		}
		mesh.colors = colors;
	}

	public Color GetColor(){
		return mesh.colors[0];
	}

}
