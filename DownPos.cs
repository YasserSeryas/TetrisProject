public event EventHandler Tick;
{
    downPos++;
    moveShape();
    if (gameSpeed => slow)
    {
        gameSpeed += (gameSlow/500f);
    }
    elseif (gameSpeed => normal){
        gameSpeed += (gameNormal/1000f);
    }
    elseif (gameSpeed => fast){
        gameSpeed += (gameFast/2000f);
    }
    else(keyBinding){
        case "Down";
        downPos++;
    }
}