using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Marriage_Agency_Women_.Models.Values.Initializers;

namespace Marriage_Agency_Women_.Models.Values
{
    public class Values
    {
        private Lazy<ValuesProvider> _locations = new Lazy<ValuesProvider>(() => new ValuesProvider(new LocationsInitializer()));
        private Lazy<ValuesProvider> _religions = new Lazy<ValuesProvider>(() => new ValuesProvider(new ReligionsInitializer()));
        private Lazy<ValuesProvider> _activities = new Lazy<ValuesProvider>(() => new ValuesProvider(new ActivitiesInitializer()));
        private Lazy<ValuesProvider> _posts = new Lazy<ValuesProvider>(() => new ValuesProvider(new PostsInitializer()));
        private Lazy<ValuesProvider> _educations = new Lazy<ValuesProvider>(() => new ValuesProvider(new EducationsInitializer()));
        private Lazy<ValuesProvider> _languages = new Lazy<ValuesProvider>(() => new ValuesProvider(new LanguagesInitializer()));
        private Lazy<ValuesProvider> _relationships = new Lazy<ValuesProvider>(() => new ValuesProvider(new RelationshipsInitializer()));
        private Lazy<ValuesProvider> _numberOfChildren = new Lazy<ValuesProvider>(() => new ValuesProvider(new NumberOfChildrenInitializer()));
        private Lazy<ValuesProvider> _figures = new Lazy<ValuesProvider>(() => new ValuesProvider(new FiguresInitializer()));
        private Lazy<ValuesProvider> _eyeColors = new Lazy<ValuesProvider>(() => new ValuesProvider(new EyeColorsInitializer()));
        private Lazy<ValuesProvider> _hairColors = new Lazy<ValuesProvider>(() => new ValuesProvider(new HairColorsInitializer()));
        private Lazy<ValuesProvider> _alcohol = new Lazy<ValuesProvider>(() => new ValuesProvider(new AlcoholInitializer()));
        private Lazy<ValuesProvider> _desiredAges = new Lazy<ValuesProvider>(() => new ValuesProvider(new DesiredAgesInitializer()));
        private Lazy<ValuesProvider> _hobbies = new Lazy<ValuesProvider>(() => new ValuesProvider(new HobbiesInitializer()));
        private Lazy<ValuesProvider> _lifestyles = new Lazy<ValuesProvider>(() => new ValuesProvider(new LifestylesInitializer()));
        private Lazy<ValuesProvider> _knowledge = new Lazy<ValuesProvider>(() => new ValuesProvider(new KnowledgeInitializer()));

        //
        //
        //

        public IDictionary<int, ViewValue> Locations
        {
            get { return _locations.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> Religions
        {
            get { return _religions.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> Activities
        {
            get { return _activities.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> Posts
        {
            get { return _posts.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> Educations
        {
            get { return _educations.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> Languages
        {
            get { return _languages.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> Relationships
        {
            get { return _relationships.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> NumberOfChildren
        {
            get { return _numberOfChildren.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> Figures
        {
            get { return _figures.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> EyeColors
        {
            get { return _eyeColors.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> HairColors
        {
            get { return _hairColors.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> Alcohol
        {
            get { return _alcohol.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> DesiredAges
        {
            get { return _desiredAges.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> Hobbies
        {
            get { return _hobbies.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> Lifestyles
        {
            get { return _lifestyles.Value.Dictionary; }
        }

        public IDictionary<int, ViewValue> Knowledge
        {
            get { return _knowledge.Value.Dictionary; }
        }

        //
        //
        //

        public IList<SelectListItem> GetSelectListItems(IDictionary<int, ViewValue> values, ValuesLanguage lang)
        {
            List<SelectListItem> listToReturn = new List<SelectListItem>();

            foreach (KeyValuePair<int, ViewValue> keyValue in values.OrderBy(v => v.Value.Position))
            {
                SelectListItem item = new SelectListItem();
                item.Value = keyValue.Key.ToString();
                switch (lang)
                {
                    case ValuesLanguage.Russian:
                        item.Text = keyValue.Value.Russian;
                        break;
                    case ValuesLanguage.English:
                        item.Text = keyValue.Value.English;
                        break;
                    case ValuesLanguage.Japanese:
                        item.Text = keyValue.Value.Japanese;
                        break;
                    default:
                        throw new ApplicationException("language '" + lang + "' not supported");
                }
                listToReturn.Add(item);
            }
            return listToReturn;
        }
    }
}