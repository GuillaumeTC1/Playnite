using Playnite.FullscreenApp.ViewModels;
using Playnite.FullscreenApp.ViewModels.DesignData;
using Playnite.SDK;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Playnite.FullscreenApp.Controls
{
    [TemplatePart(Name = "PART_ImageCover", Type = typeof(Image))]
    public class GameListItem : Control
    {
        private readonly FullscreenAppViewModel mainModel;
        private Image ImageCover;

        static GameListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameListItem), new FrameworkPropertyMetadata(typeof(GameListItem)));
        }

        public GameListItem() : this(FullscreenApplication.Current?.MainModel)
        {
        }

        public GameListItem(FullscreenAppViewModel mainModel)
        {
            if (DesignerProperties.GetIsInDesignMode(this))
            {
                this.mainModel = DesignMainViewModel.DesignIntance;
            }
            else if (mainModel != null)
            {
                this.mainModel = mainModel;
                // Done via event instead of input binding because input binding disables item select on righ-click.
                PreviewMouseRightButtonUp += GameListItem_MouseRightButtonUp;
            }
        }

        private void GameListItem_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (mainModel.OpenGameMenuCommand.CanExecute())
            {
                mainModel.OpenGameMenuCommand.Execute();
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            ImageCover = Template.FindName("PART_ImageCover", this) as Image;
            if (ImageCover != null)
            {
                var sourceBinding = new PriorityBinding();
                sourceBinding.Bindings.Add(new Binding()
                {
                    Path = new PropertyPath(nameof(GamesCollectionViewEntry.FullscreenListItemCoverObject)),
                    IsAsync = mainModel.AppSettings.Fullscreen.AsyncImageLoading,
                    Converter = new NullToDependencyPropertyUnsetConverter(),
                    Mode = BindingMode.OneWay
                });
                sourceBinding.Bindings.Add(new Binding()
                {
                    Path = new PropertyPath(nameof(GamesCollectionViewEntry.DefaultFullscreenListItemCoverObject)),
                    Converter = new NullToDependencyPropertyUnsetConverter(),
                    Mode = BindingMode.OneWay
                });

                BindingOperations.SetBinding(ImageCover, Image.SourceProperty, sourceBinding);
            }

            ControlTemplateTools.InitializePluginControls(
                mainModel.Extensions,
                Template,
                this,
                ApplicationMode.Fullscreen,
                this,
                $"DataContext.{nameof(GamesCollectionViewEntry.Game)}");
        }
    }
}