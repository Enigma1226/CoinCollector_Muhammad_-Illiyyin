using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalCoin;
    private int koinTerkumpul = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // TODO: Hitung jumlah koin di scene saat mulai.
        totalCoin = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // Update is called once per frame
    public void AmbilKoin()
    {
        koinTerkumpul++;
        // TODO: Jika koinTerkumpul == totalCoin, panggil Menang().
        if (koinTerkumpul == totalCoin)
{
    Menang();
}
    }

    void Menang()
    {
        Debug.Log("KAMU MENANG");
    }
}

