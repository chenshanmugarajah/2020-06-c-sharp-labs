using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BlogApp;
using EFGetStarted;

namespace WPFLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CRUDManager _crudManager = new CRUDManager();
        public MainWindow()
        {
            InitializeComponent();
            ReadBlog();
            ReadPost();
        }

        public void ReadBlog()
        {
            ListBoxBlog.ItemsSource = _crudManager.ReadBlogs();
        }

        public void ReadPost()
        {
            ListBoxPost.ItemsSource = _crudManager.ReadPosts();
        }

        public void ReadPost(Blog blog)
        {
            ListBoxPost.ItemsSource = _crudManager.ReadPosts(blog);
        }

        private void ListBoxBlog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxBlog.SelectedItem != null)
            {
                _crudManager.SetCurrentBlog(ListBoxBlog.SelectedItem);
                ListBoxPost.ItemsSource = _crudManager.ReadPosts(_crudManager.SelectedBlog);
            }
        }

        private void ListBoxPost_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxPost.SelectedItem != null)
            {
                _crudManager.SetCurrentPost(ListBoxPost.SelectedItem);
                FillPostFields();
            } else
            {
                ClearPostFields();
            }
        }

        public void FillPostFields()
        {
            LabelBlogIdOutput.Content = _crudManager.SelectedPost.BlogId;
            LabelPostIdOutput.Content = _crudManager.SelectedPost.PostId;
            TextPostTitleOutput.Text = _crudManager.SelectedPost.Title;
            TextPostContentOutput.Text = _crudManager.SelectedPost.Content;
        }

        public void ClearPostFields()
        {
            LabelBlogIdOutput.Content = "";
            LabelPostIdOutput.Content = "";
            TextPostTitleOutput.Text = "";
            TextPostContentOutput.Text = "";
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (_crudManager.SelectedBlog != null)
            {
                _crudManager.UpdatePost(TextPostTitleOutput.Text, TextPostContentOutput.Text);
                ListBoxPost.ItemsSource = _crudManager.ReadPosts(_crudManager.SelectedBlog);
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (_crudManager.SelectedBlog != null)
            {
                _crudManager.DeletePost(_crudManager.SelectedPost);
                ReadPost(_crudManager.SelectedBlog);
            } 
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (_crudManager.SelectedBlog != null)
            {
                _crudManager.CreatePost(TextPostTitleOutput.Text, TextPostContentOutput.Text);
                ReadPost(_crudManager.SelectedBlog);
            }
        }

        private void ButtonCreateBlog_Click(object sender, RoutedEventArgs e)
        {
            _crudManager.CreateBlog(TextBlogNameInput.Text);
            ReadBlog();
        }

        private void ButtonDeleteBlog_Click(object sender, RoutedEventArgs e)
        {
            _crudManager.DeleteBlog();
            ReadBlog();
            ReadPost();
        }
    }
}
