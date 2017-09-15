using GTAVBETrainerDotNet.Menu;

namespace GTAVBETrainerDotNet
{
    /// <summary>
    /// Language control
    /// </summary>
    public static class Language
    {
        /// <summary>
        /// Language code for English
        /// </summary>
        public const string CODE_ENGLISH = "enUS";

        /// <summary>
        /// Language code for Chinese Traditional
        /// </summary>
        public const string CODE_CHINESE_TRADITIONAL = "zhTW";

        /// <summary>
        /// Sets trainer language to English
        /// </summary>
        /// <param name="sender">Source menu item</param>
        public static void SetToEnglish(MenuItem sender)
        {
            Trainer.LanguageCode = CODE_ENGLISH;
            Feature.Config.DoAutoSave();
        }

        /// <summary>
        /// Sets trainer language to Chinese Traditional
        /// </summary>
        /// <param name="sender">Source menu item</param>
        public static void SetToChineseTraditional(MenuItem sender)
        {
            Trainer.LanguageCode = CODE_CHINESE_TRADITIONAL;
            Feature.Config.DoAutoSave();
        }
    }
}
