import { Blog_Test_Petros_OhanyanTemplatePage } from './app.po';

describe('Blog_Test_Petros_Ohanyan App', function() {
  let page: Blog_Test_Petros_OhanyanTemplatePage;

  beforeEach(() => {
    page = new Blog_Test_Petros_OhanyanTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
