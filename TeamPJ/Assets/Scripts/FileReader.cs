using System.IO;
using UnityEngine;
using System.Collections.Generic;

public class FileReader : MonoBehaviour
{
	public static string[] Read(string fileName)
	{
		StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));

		List<string> strList = new List<string>();

		for (;;)
		{
			strList.Add(sr.ReadLine());
			if (sr.EndOfStream)
				break;
		}

		sr.Close();

		return strList.ToArray();
	}
}