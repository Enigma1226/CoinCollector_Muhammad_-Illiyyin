using UnityEngine;
using UnityEngine.InputSystem; // Untuk InputSystem.
public class PlayerMovement : MonoBehaviour
{
    public int skor = 0;
    public float kecepatan = 5f;

    private Vector2 arahGerak; // Nilai Dari Action "Move".

    // Dipanggil otomatis oleh komponen Player Input.
    // Saat action "Move" pada asset InputSystem_Actions aktif.
    // Nama method wajib ON + nama action -> OnMove.
    // Start is called once before the first execution of Update after the MonoBehaviour is created.
    void OnMove(InputValue value)
    {
        // TODO: Ambil nilai Vector2 dari input, simpan ke arahGerak.

        arahGerak = value.Get<Vector2>();
    }

    // Update is called once per frame.
    void Update()
    {
        // TODO: Gerakkan objek memakai arahGerak.
        // Ingat kalikan kecepatan DAN Time.deltaTime!.

        Vector3 arah = new Vector3(arahGerak.x, arahGerak.y, 0);
        transform.position += arah * kecepatan * Time.deltaTime;
    }
    
    // Dipanggil otomatis saat Player menyentuh objek ber-Trigger.
    void OnTriggerEnter2D(Collider2D other)
    {
        // TODO: Cek apakah yang disentuh punya tag "Coin".
        if (other.CompareTag("Coin"))
        {
            // TODO: Tambah skor sebanyak 1
            skor++;
            // TODO: Hancurkan koin yang tersentuh.
            Destroy(other.gameObject);
            // TODO: Tampilkan skor ke console
            Debug.Log("Skor: " + skor);

            FindFirstObjectByType<GameManager>().AmbilKoin();
        }
    }
}
