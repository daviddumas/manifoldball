/// <summary>
/// Borromean rings 2-fold branched cover
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoroTiling: Tiling {
	private int N;
	private float cubesize;
	private Matrix4x4 inverseOrigin;

	public BoroTiling(Matrix4x4 origin, int N, float cubesize)
	{
		this.N = N;
		this.cubesize = cubesize;
		this.inverseOrigin = origin.inverse;

		Debug.Log ("BoroTiling is just a placeholder; the tiling is not implemented yet!");
	}

	public override System.Collections.IEnumerator GetEnumerator()
	{
		yield return Matrix4x4.identity;
	}

	public override Matrix4x4 TileContaining(Matrix4x4 P)
	{
		return Matrix4x4.identity;
 	}

}