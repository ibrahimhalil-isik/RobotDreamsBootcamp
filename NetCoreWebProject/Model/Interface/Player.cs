﻿namespace NetCoreWebProject.Model.Interface
{
    public class Player
    {
        public string Name { get; set; }        
        public int Age { get; set; }
        public Weapon Weapon { get; set; }
        public int LifeBar { get; set; }

        public string TakeAim()
        {
            if (Weapon is IZoomable)
            {
                IZoomable zoom = (IZoomable)Weapon;
                return zoom.Zoom();
            }
            return string.Empty;
        }

        public string Attack()
        {
            return "Ateş ediliyor.";            
        }

    }
}
