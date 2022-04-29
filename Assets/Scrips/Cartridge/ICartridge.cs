﻿namespace Scrips.Cartridge
{
    public interface ICartridge
    {
        public void ToRun(IMovement movement);

        public void DestroyYourself();
    }
}