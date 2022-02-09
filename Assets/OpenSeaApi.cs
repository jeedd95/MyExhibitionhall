using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class OpenSeaApi : MonoBehaviour
{
    [SerializeField] private RawImage img;
    // Start is called before the first frame update
    void Start()
    {
        fetchNft();
    }

    private void fetchNft()
    {
        //var url = "https://api.opensea.io/api/v1/assets?embed=true";
        var url = "https://testnets-api.opensea.io/api/v1/assets?&order_direction=desc&offset=0&limit=20"; // Retrieving assets
        //var url = "https://testnets-api.opensea.io/api/v1/collections?asset_owner=0xad3909907136cdc1a0e4634a8e2795fd10d59c14&offset=0&limit=300"; //Retrieving collections

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();

        OpenSea info = JsonUtility.FromJson<OpenSea>(json);
        StartCoroutine(DownloadImage(info.assets[8].image_url));
        
        //OpenSea2 info2 = JsonUtility.FromJson<OpenSea2>(json);
        //StartCoroutine(DownloadImage(info2.collections[0].image_url.ToString()));
    }

    IEnumerator DownloadImage(string url)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.SendWebRequest();

        Texture texture = DownloadHandlerTexture.GetContent(www);
        img.texture = texture;
    }
}
