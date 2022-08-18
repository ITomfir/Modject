using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine;

public class LanguageSwitcher : MonoBehaviour
{
    [SerializeField] private Locale _locale;

    public void Switch () {
        LocalizationSettings.SelectedLocale = _locale;
    }
}
