using UnityEngine.SceneManagement;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    private AudioSource audioSource;
    public AudioClip clip;
    private VolumeSlider slider; // VolumeSlider ���� ���� �߰�

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }

        SceneManager.sceneLoaded += OnSceneLoaded;

        // ������ �� �����̴��� ã�Ƽ� ����
        slider = FindObjectOfType<VolumeSlider>();
        // ���۽� �����̴� �Ⱥ��̰��ϱ�
        if (slider != null)
        {
            slider.gameObject.SetActive(false);
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "SettingScene") // �� �̸��� �����մϴ�.
        {
            // ȯ�� ���� ������ �����̴��� �����ϰ� �ִٸ� Ȱ��ȭ�ϰ� ���� ������ �����ϰ� ����
            if (slider != null)
            {
                slider.gameObject.SetActive(true);
                slider.SetSliderValue(audioSource.volume);
                slider.OnVolumeChange += SetVolume;
            }
        }
        else
        {
            // �ٸ� �������� �����̴��� ��Ȱ��ȭ
            if (slider != null)
            {
                slider.OnVolumeChange -= SetVolume;
                slider.gameObject.SetActive(false);
            }
        }
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = Mathf.Clamp(volume, 0f, 1f);
    }
}