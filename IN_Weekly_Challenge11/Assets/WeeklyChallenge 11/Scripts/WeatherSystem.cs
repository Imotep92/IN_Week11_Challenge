using UnityEngine;
using UnityEngine.Rendering;
using TMPro;
using UnityEngine.VFX;
using UnityEngine.UI;

public class WeatherSystem : MonoBehaviour
{
    [Header("Global")]
    public static WeatherSystem _weatherSystem;
    public Volume _currentVolume;
    public Material skyboxMaterial, globalMaterial;
    public Light sunLight;
    public TMP_Text weatherText;
    [SerializeField] Button Winter, Autumn, Rain, Summer;

    #region Winter Variables 
    [Header("Winter Assets")]
    //public ParticleSystem winterParticleSystem;
    [SerializeField] bool _isWinter;
    [SerializeField] Volume winterVolume;
    [SerializeField] VisualEffect _snowFall;
    [SerializeField] Material _snowMaterial;
    #endregion

    #region Rain Variables 
    [Header("Rain Assets")]
    [SerializeField] bool _isRaining;
    //public ParticleSystem rainParticleSystem;
    [SerializeField] Volume rainVolume;
    [SerializeField] VisualEffect _rainFall;
    #endregion

    #region Autumn Variables
    [Header("Autumn Assets")]
    [SerializeField] bool _isAutumn;
    //public ParticleSystem autumnParticleSystem;
    [SerializeField] Volume autumnVolume;
    #endregion

    #region Summer Variables
    [Header("Summer Assets")]
    [SerializeField] bool _isSummer;
    //public ParticleSystem summerParticleSystem;
    [SerializeField] Volume summerVolume;
    #endregion

    private void Awake()
    {
        _weatherSystem = this;
    }

    private void Start()
    {
        _currentVolume = null; // starting with no Weather effects active
        Debug.Log("_currenetVolume is null");

    }

    public void SummerWeather()
    {
        DisableWintertWeather();

        DisableRainyWeather();

        DisableAutumnWeather();

        if (_currentVolume == null || !_isSummer)
        {
            _isSummer = true;
            summerVolume.enabled = true;
            //globalMaterial.SetFloat("SnowFade", 0);
            Debug.Log("It is Summer");
        }
        _currentVolume = summerVolume;
    }
    private void DisableSummerWeather()
    {
        if (_currentVolume = summerVolume)
        {
            _currentVolume = null;
            Debug.Log("_currentVolume is null");
            _isSummer = false;
            summerVolume.enabled = false;
            Debug.Log("Summer has stopped");
        }
    }

    public void WinterWeather()
    {
        DisableSummerWeather();

        DisableRainyWeather();

        DisableAutumnWeather();

        if (_currentVolume == null || !_isWinter)
        {
            _isWinter = true;
            winterVolume.enabled = true;
            //globalMaterial.SetFloat("SnowFade", 1);
            _snowFall.Play();
            Debug.Log("It is Winter");
        }
        _currentVolume = winterVolume;
    }

    private void DisableWintertWeather()
    {
        if (_currentVolume = winterVolume)
        {
            _currentVolume = null;
            Debug.Log("_currentVolume is null");
            _isWinter = false;
            winterVolume.enabled = false;
            //globalMaterial.SetFloat("SnowFade", 0);
            _snowFall.Stop();
            Debug.Log("Winter has stopped");
        }
    }

    public void RainyWeather()
    {
        DisableSummerWeather();

        DisableWintertWeather();

        DisableAutumnWeather();

        if (_currentVolume == null || !_isRaining)
        {
            _isRaining = true;
            rainVolume.enabled = true;
            _rainFall.Play();
            Debug.Log("April Showers!");
        }
        _currentVolume = rainVolume;
        Debug.Log("It is Raining/Spring");
    }

    private void DisableRainyWeather()
    {
        if (_currentVolume = rainVolume)
        {
            _currentVolume = null;
            Debug.Log("_currentVolume is null");
            _isRaining = false;
            rainVolume.enabled = false;
            _rainFall.Stop();
            Debug.Log("Rain has stopped");
        }
    }

    public void AutumnWeather()
    {
        DisableSummerWeather();

        DisableWintertWeather();

        DisableRainyWeather();

        if (_currentVolume == null || !_isAutumn)
        {
            _isAutumn = true;
            autumnVolume.enabled = true;
            Debug.Log("It is Autumn");
        }
        _currentVolume = autumnVolume;
        Debug.Log("It is Autumn");
    }

    private void DisableAutumnWeather()
    {
        if (_currentVolume = autumnVolume)
        {
            _currentVolume = null;
            Debug.Log("_currentVolume is null");
            _isAutumn = false;
            autumnVolume.enabled = false;
            Debug.Log("Autumn has stopped");
        }
    }
}
