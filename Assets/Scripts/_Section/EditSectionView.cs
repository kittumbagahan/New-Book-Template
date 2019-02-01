using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditSectionView : MonoBehaviour {

   public InputField txtSectionName;
  
   public Dropdown dropdownGradeLevel;

   public Button btnOK;
   public Button btnClose;

   public string GradeLevel
   {
      get
      {
         return dropdownGradeLevel.captionText.text;
      }
      private set { }
   }
}
