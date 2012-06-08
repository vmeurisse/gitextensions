using System;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel;
using System.Windows.Forms;

namespace ResourceManager.Translation
{
    public static class TranslationUtl
    {
        private static bool AllowTranslateProperty(string text)
        {
            if (text == null)
                return false;
            foreach (char c in text)
                if (Char.IsLetter(c))
                    return true;
            return false;
        }

        public static void AddTranslationItemsFromFields(string category, object obj, Translation translation)
        {
            AddTranslationItemsFromFields(category, obj as IDontTranslate, obj, translation);
        }

        public static void AddTranslationItemsFromFields(string category, IDontTranslate dontTranslateComponents, object obj, Translation translation)
        {
            if (obj == null)
                return;

            Action<string, object, PropertyInfo> action = delegate(string item, object itemObj, PropertyInfo propertyInfo)
            {
                var value = (string)propertyInfo.GetValue(itemObj, null);
                if (AllowTranslateProperty(value))
                    translation.AddTranslationItem(category, item, propertyInfo.Name, value);
            };
            ForEachField(obj, dontTranslateComponents, action);
        }

        public static void TranslateItemsFromFields(string category, object obj, Translation translation)
        {
            TranslateItemsFromFields(category, obj as IDontTranslate, obj, translation);
        }

        public static void TranslateItemsFromFields(string category, IDontTranslate dontTranslateComponents, object obj, Translation translation)
        {
            if (obj == null)
                return;

            Action<string, object, PropertyInfo> action = delegate(string item, object itemObj, PropertyInfo propertyInfo)
            {
                string value = translation.TranslateItem(category, item, propertyInfo.Name, null);
                if (value != null)
                    propertyInfo.SetValue(itemObj, value, null);
                else if (propertyInfo.Name == "ToolTipText" && !String.IsNullOrEmpty((string)propertyInfo.GetValue(itemObj, null)))
                {
                    value = translation.TranslateItem(category, item, "Text", null);
                    if (value != null)
                        propertyInfo.SetValue(itemObj, value, null);
                }
            };
            ForEachField(obj, dontTranslateComponents, action);
        }

        private static void ForEachField(object obj,  IDontTranslate dontTranslateComponents, Action<string, object, PropertyInfo> action)
        {
            if (obj == null)
                return;
            foreach (FieldInfo fieldInfo in obj.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
            {
                Action<PropertyInfo> paction = delegate(PropertyInfo propertyInfo) 
                {
                    action(fieldInfo.Name, fieldInfo.GetValue(obj), propertyInfo);
                };

                //Skip controls with a name started with "_NO_TRANSLATE_"
                //this is a naming convention, these are not translated
                if (fieldInfo.Name.StartsWith("_NO_TRANSLATE_"))
                    continue;
                if (fieldInfo.FieldType.IsSubclassOf(typeof(Component)))
                {
                    Component c = fieldInfo.GetValue(obj) as Component;
                    if (dontTranslateComponents != null && dontTranslateComponents.CheckComponent(c))
                        continue;

                    Func<PropertyInfo, bool> IsTranslatableItem = IsTranslatableItemInComponent;

                    ForEachProperty(c, paction, IsTranslatableItem);
                }
                else if (fieldInfo.FieldType.IsSubclassOf(typeof(DataGridViewColumn)))
                {
                    DataGridViewColumn c = fieldInfo.GetValue(obj) as DataGridViewColumn;

                    Func<PropertyInfo, bool> IsTranslatableItem = delegate(PropertyInfo propertyInfo)
                    {
                        return IsTranslatableItemInDataGridViewColumn(propertyInfo, c);
                    };

                    ForEachProperty(c, paction, IsTranslatableItem);                    
                }
            }
        }

        private static void ForEachProperty(object obj, Action<PropertyInfo> action, Func<PropertyInfo, bool> IsTranslatableItem)
        {
            if (obj == null)
                return;

            foreach (PropertyInfo propertyInfo in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic))
                if (IsTranslatableItem(propertyInfo))
                    action(propertyInfo);
        }

        private static bool IsTranslatableItemInComponent(PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType != typeof(string))
                return false;
            if (propertyInfo.Name.Equals("Caption", StringComparison.CurrentCulture))
                return true;
            if (propertyInfo.Name.Equals("Text", StringComparison.CurrentCulture))
                return true;
            if (propertyInfo.Name.Equals("ToolTipText", StringComparison.CurrentCulture))
                return true;
            if (propertyInfo.Name.Equals("Title", StringComparison.CurrentCulture))
                return true;
            return false;
        }

        private static bool IsTranslatableItemInDataGridViewColumn(PropertyInfo propertyInfo, DataGridViewColumn viewCol)
        {
            return propertyInfo.Name.Equals("HeaderText", StringComparison.CurrentCulture) && viewCol.Visible;
        }
    }
}
