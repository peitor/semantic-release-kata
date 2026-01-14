namespace LiftButton;

public class Lift
{
    private bool _lightsOn = false;

    public bool DoorsClosed 
    { 
        get
        {
            return true;
        }
        
    }

    public bool LightsOn 
    { 
        get
        {   return _lightsOn;
        }
        private set;

    }

    public void PressButton()
    {
        this._lightsOn = true;
    }
}