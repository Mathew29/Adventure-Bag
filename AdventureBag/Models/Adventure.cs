using System;
using System.Collections.Generic;


namespace Adventure
{

  public static class AdventureTime
  {
    public static Bag bag;
    public static Shop shop;
    public static NoticeBoard notice;


    static AdventureTime()
    {
      bag = new Bag();
      shop = new Shop();
      notice = new NoticeBoard();
    }

  }


}
