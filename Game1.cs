using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_2___Scaling_With_Rectangles
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture;
        Texture2D rectangleTexture;

        SpriteFont titleFont;

        Rectangle headRect, mouthRect, leftEyeRect, rightEyeRect;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.Window.Title = "Lesson 2 - Scaling";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = 800;  // set this value to the desired width of your window
            _graphics.PreferredBackBufferHeight = 500;   // set this value to the desired height of your window
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            headRect = new Rectangle(150, 0, 500, 500);
            leftEyeRect = new Rectangle(250, 100, 100, 75);
            rightEyeRect = new Rectangle(450, 100, 100, 75);
            mouthRect = new Rectangle(300, 350, 200, 50);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            titleFont = Content.Load<SpriteFont>("Title");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            // Smile Face
            _spriteBatch.Draw(circleTexture, headRect, Color.Yellow);
            _spriteBatch.Draw(circleTexture, leftEyeRect, Color.Black);
            _spriteBatch.Draw(circleTexture, rightEyeRect, Color.Black);
            _spriteBatch.Draw(rectangleTexture, mouthRect, Color.Black);

            // Text
            _spriteBatch.DrawString(titleFont, "SMILE", new Vector2(340, 355), Color.White);
            
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
