using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAddButton : MonoBehaviour
{
    public ImageAddedEvent onImageAdded = new ImageAddedEvent();
    public Sprite tree;
    public Sprite emttree;
    private List<GameObject> _sprites;
    private List<Vector3> _listPos;

    public void Start()
    {
        _sprites = new List<GameObject>();
        _listPos = new List<Vector3>(){
        new Vector3(0f, 0f, 0f),
        new Vector3(3f, 0f, 0f),
        new Vector3(-3f, 0f, 0f),
        new Vector3(0f, 5f, 0f),
        new Vector3(-3f, 5f, 0f),
        new Vector3(3f, 5f, 0f),
        new Vector3(-5f, 5f, 0f)
        };
    }

    public void OnButtonClicked(Sprite newSprite)
    {
        GameObject newImageObject = new GameObject("NewImage");
        SpriteRenderer imageComponent = newImageObject.AddComponent<SpriteRenderer>();
        imageComponent.sprite = newSprite;


        int pcount;



        _sprites.Add(newImageObject);


        if (newImageObject.GetComponent<SpriteRenderer>().sprite.name == "tree")
        {
            pcount = Random.Range(0, 3);
            newImageObject.transform.position = _listPos[pcount];
        }
        else if (newImageObject.GetComponent<SpriteRenderer>().sprite.name == "snow")
        {
            pcount = Random.Range(3, 6);
            Debug.Log(_listPos[pcount]);
            newImageObject.transform.position = _listPos[pcount];
        }
        else if (newImageObject.GetComponent<SpriteRenderer>().sprite.name == "sun")
        {
            newImageObject.transform.position = _listPos[6];
        }
        else if (newImageObject.GetComponent<SpriteRenderer>().sprite.name == "cloud")
        {
            pcount = Random.Range(3, 6);
            newImageObject.transform.position = _listPos[pcount];
        }

        List<GameObject> tmp = new List<GameObject>();

        for (int i = 0; i < _sprites.Count; i++)
        {  
           
            if (newSprite.name == "tree")
            {
                if (_sprites[i].GetComponent<SpriteRenderer>().sprite.name == "snow")
                    tmp.Add(_sprites[i]);
                else if (_sprites[i].GetComponent<SpriteRenderer>().sprite.name == "emp_tree")
                    _sprites[i].GetComponent<SpriteRenderer>().sprite = tree;
                else if (_sprites[i].GetComponent<SpriteRenderer>().sprite.name == "cloud")
                    tmp.Add(_sprites[i]);
            }
            else if (newSprite.name == "snow")
            {
                if (_sprites[i].GetComponent<SpriteRenderer>().sprite.name == "tree")
                    _sprites[i].GetComponent<SpriteRenderer>().sprite = emttree;
                else if (_sprites[i].GetComponent<SpriteRenderer>().sprite.name == "sun")
                    tmp.Add(_sprites[i]);
            }
            else if(newSprite.name == "cloud")
            {
                if(_sprites[i].GetComponent<SpriteRenderer>().sprite.name == "sun")
                    tmp.Add(_sprites[i]);
                else if(_sprites[i].GetComponent<SpriteRenderer>().sprite.name == "tree")
                    _sprites[i].GetComponent<SpriteRenderer>().sprite = emttree;
                else if (_sprites[i].GetComponent<SpriteRenderer>().sprite.name == "snow")
                    tmp.Add(_sprites[i]);
            }
            else if(newSprite.name == "sun")
            {
                if (_sprites[i].GetComponent<SpriteRenderer>().sprite.name == "snow")
                    tmp.Add(_sprites[i]);
                else if (_sprites[i].GetComponent<SpriteRenderer>().sprite.name == "cloud")
                    tmp.Add(_sprites[i]);
                else if (_sprites[i].GetComponent<SpriteRenderer>().sprite.name == "emp_tree")
                    _sprites[i].GetComponent<SpriteRenderer>().sprite = tree;
            }
        }

        foreach (var item in tmp)
        {
            _sprites.Remove(item);
            Destroy(item);
        }
    
 

        onImageAdded.Invoke(newSprite);
    }
}
