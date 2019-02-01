﻿using UnityEngine;
using System.Collections;

public abstract class StoryBookEnum
{


}

public enum AssetBundleCategory
{
   BOOKSHELF_SCENE,
   BOOK_SCENE,
   ACTIVITY_SELECTION_SCENE,
   ACTIVITY_SCENE,
   SECTION_BOOK_DB_DATA_FILE,
   STORYBOOK_ACTIVITY_SECLECTION_DATA_FILE,
   LAUNCHER_SCENE
};

public enum StoryBook
{
   NULL, FAVORITE_BOX, AFTER_THE_RAIN, CHAT_WITH_MY_CAT, COLORS_ALL_MIXED_UP, WHAT_DID_YOU_SEE,
   ABC_CIRCUS, JOEY_GO_TO_SCHOOL, SOUNDS_FANTASTIC, YUMMY_SHAPES, TINA_AND_JUN, BOOK_TEST_1
};

public enum EColor
{

   non, red, green, blue, purple, orange, yellow, pink, teal, white, black, brown, cyan
}
public enum EAlphabet
{
   a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, non
}
public enum EDragDirection
{
   all, x, y
}

public enum ETiltDirection { left, right }
public enum Direction { up, down, left, right }