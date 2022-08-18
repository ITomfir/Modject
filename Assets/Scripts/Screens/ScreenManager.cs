using System.Collections;
using System.Collections.Generic;
using System;

public class ScreenManager : IScreenManager
{
    private List<IScreen> _screens = new List<IScreen>();
    private IScreen _oldScreen;

    public void Init (IScreenProvider provider) {
        _screens.AddRange(provider.Get());
    }

    public void Show (IScreen screen) {
        if (!_screens.Contains(screen)) throw new NullReferenceException($"{screen} not in list"); 

        if (_oldScreen != null) Close(_oldScreen);
        _oldScreen = screen;

        screen.Show();
    }
    
    public void Close (IScreen screen) {
        if (!_screens.Contains(screen)) throw new NullReferenceException($"{screen} not in list"); 

        screen.Close();
    }
}
