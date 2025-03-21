using System;
using UnityEngine;

[CreateAssetMenu(fileName = "MyReadme", menuName = "ScriptableObjects/MyReadme", order = 1)]
public class MyReadme : ScriptableObject
{
    [SerializeField]
    private string title;
    public string Title => title;
    //[SerializeField]
    //private Section[] sections;
    //public Section[] Sections => sections;
    [SerializeField]
    private bool loadedLayout;
    public bool LoadedLayout { get { return loadedLayout; } set { loadedLayout = value; } }

    [SerializeField]
    private string zombieName;
    public string ZombieName { get { return zombieName; } }
    [SerializeField]
    private int hp;
    public int Hp { get { return hp; } }
    [SerializeField]
    private int damage;
    public int Damage { get { return damage; } }
    [SerializeField]
    private float sightRange;
    public float SightRange { get { return sightRange; } }
    [SerializeField]
    private float moveSpeed;
    public float MoveSpeed { get { return moveSpeed; } }


    //[Serializable]
    //public class Section
    //{
    //    [SerializeField]
    //    public string heading, text, linkText, url;
    //}
}
