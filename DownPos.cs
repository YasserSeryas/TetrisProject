public event EventHandler Tick;
    {
        downPos++;
        moveShape();
        if (gameSpeed => slow)
        {
            gameSpeed += (gameSlow/500f);
        }
        if (gameSpeed => normal)
        {
            gameSpeed += (gameNormal/1000f);
        }
        if (gameSpeed => fast)
        {
            gameSpeed += (gameFast/2000f);
        }
        else(keyBinding)
        {
            case "Down":
                downPos++;
        }
    }